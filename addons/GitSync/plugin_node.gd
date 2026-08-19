@tool
extends EditorPlugin
var b:Button;var q:Array=[];var p:=false;var i:=false;var m:=Mutex.new();var t:Timer
func _enter_tree()->void:
	b=Button.new();b.flat=true;b.text="● GitSync: OK";b.add_theme_color_override("font_color",Color.GREEN)
	add_control_to_dock(EditorPlugin.DOCK_SLOT_LEFT_UL,b);if b.get_parent():b.get_parent().name="GitSync"
	t=Timer.new();t.one_shot=true;t.wait_time=0.6;t.timeout.connect(_on_t);add_child(t)
	get_editor_interface().get_resource_filesystem().filesystem_changed.connect(_on_fs)
func _exit_tree()->void:
	var efs=get_editor_interface().get_resource_filesystem()
	if efs.filesystem_changed.is_connected(_on_fs):efs.filesystem_changed.disconnect(_on_fs)
	if b:remove_control_from_docks(b);b.queue_free()
	if t:t.queue_free()
func _notification(w:int)->void:
	if w==NOTIFICATION_APPLICATION_FOCUS_IN:i=true;_add(["pull","--rebase"])
func _on_fs()->void:
	if i:i=false;return
	t.start()
func _on_t()->void:
	_add(["add","."]);_add(["commit","-m","auto","--allow-empty"]);_add(["push"])
func _add(a:Array)->void:
	m.lock();q.append(a);var s=!p;if s:p=true
	m.unlock();if s:WorkerThreadPool.add_task(_tw)
func _tw()->void:
	while true:
		var c=null;m.lock()
		if !q.is_empty():c=q.pop_front()
		else:p=false;Callable(self,"_upd").call_deferred(Color.GREEN,"OK");m.unlock();break
		m.unlock()
		if c:
			var act="Sync..." if c[0] in ["push","pull"] else c[0]
			Callable(self,"_upd").call_deferred(Color.YELLOW,act)
			OS.execute("git",c,[],true)
func _upd(col:Color,txt:String)->void:
	if is_instance_valid(b):
		b.add_theme_color_override("font_color",col);b.text="● GitSync: "+txt
		if b.get_parent():b.get_parent().name="GitSync"
	print("GitSync Status: ",txt)
