# Mail Orders Parser

Простой сервис на FastAPI для хранения писем и заказов и первичной миграции схемы через Alembic.

## Настройка окружения
1. Установите зависимости в editable-режиме:
   ```bash
   pip install -e .
   ```
2. Укажите строку подключения к базе данных PostgreSQL через переменную окружения `DATABASE_URL`, например:
   ```bash
   export DATABASE_URL=postgresql+psycopg://user:pass@localhost:5432/mailparser
   ```

## Миграции
Создайте/обновите схему:
```bash
alembic upgrade head
```

## Запуск приложения
```bash
uvicorn mail_orders_parser.app.main:app --reload
```

Доступные проверки:
- `GET /health` — проверка доступности сервиса.
- `GET /db/ping` — проверка соединения с базой данных.
