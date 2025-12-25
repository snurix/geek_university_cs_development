from fastapi import Depends, FastAPI
from sqlalchemy import text
from sqlalchemy.orm import Session

from .db import get_session

app = FastAPI(title="Mail Orders Parser")


@app.get("/health")
def health() -> dict[str, str]:
    return {"status": "ok"}


@app.get("/db/ping")
def db_ping(session: Session = Depends(get_session)) -> dict[str, str]:
    session.execute(text("SELECT 1"))
    return {"status": "ok"}
