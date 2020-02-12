DROP DATABASE IF EXISTS websoft;
CREATE DATABASE websoft;

USE websoft;

DROP TABLE IF EXISTS tech;

CREATE TABLE tech (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    label CHAR(10),
    type VARCHAR(20)
);

INSERT INTO tech (label, type) VALUES
    ('Apache', 'Web server'),
    ('PHP', 'Server side language'),
    ('MariaDB', 'Database server'),
    ('MySQL', 'Database server'),
    ('Java', 'Programming language'),
    ('HTML', 'Programming languageXD'),
    ('JavaScript', 'Programming language');

    select * from tech;