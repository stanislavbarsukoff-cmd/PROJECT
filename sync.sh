#!/bin/bash

# 1. Проверяем наличие локальных изменений
CHANGES=$(git status --porcelain)

if [ -n "$CHANGES" ]; then
    # Если они есть, временно убираем в карман
    git stash -u
fi

# 2. Обновляем ветку с сервера
git pull origin main --rebase

if [ -n "$CHANGES" ]; then
    # Возвращаем файлы обратно в рабочую область
    git stash pop
fi

# 3. Делаем авто-коммит и пуш, если есть новые изменения
if [ -n "$(git status --porcelain)" ]; then
    git add .
    git commit -m "Auto-commit: $(date +'%Y-%m-%d %H:%M:%S')"
    git push origin main
fi