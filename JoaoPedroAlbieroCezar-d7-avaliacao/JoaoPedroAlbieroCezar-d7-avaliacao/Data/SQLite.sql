CREATE TABLE Users(
    username TEXT,
    password TEXT
    );

INSERT INTO Users(username, password)
    VALUES ('admin@email.com', 'admin123');
    
SELECT * FROM Users;