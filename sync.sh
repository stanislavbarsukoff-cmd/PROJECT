#!/bin/bash
echo "=== Авто-синхронизация Git ==="

# 1. Стягиваем актуальные изменения
git pull origin main --rebase
git add .
git commit -m "Auto-commit: $(date +'%Y-%m-%d %H:%M:%S')"
git push origin main
