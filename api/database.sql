create TABLE users(
    id SERIAL PRIMARY KEY,
    email VARCHAR(80),
    password VARCHAR(50),
    initials VARCHAR(150)
)
