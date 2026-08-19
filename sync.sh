#!/bin/bash
code --action workbench.action.files.saveAll
git pull origin main --rebase
git add .
git commit -m "Auto-commit: $(date +'%Y-%m-%d %H:%M:%S')"
