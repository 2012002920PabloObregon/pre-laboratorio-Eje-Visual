CREATE DATABASE Fixosaaa1;
USE Fixosaaa1;

CREATE TABLE address (
    address_id INT(11) PRIMARY KEY,
    street VARCHAR(45),
    city VARCHAR(45),
    country VARCHAR(45)
);

CREATE TABLE users (
    user_id INT(11) PRIMARY KEY,
    first_name VARCHAR(45),
    last_name VARCHAR(45),
    age INT(11),
    address_address_id INT(11),
    FOREIGN KEY (address_address_id) REFERENCES address(address_id)
);

CREATE TABLE genre (
    genre_id INT(11) PRIMARY KEY,
    genre_name VARCHAR(45)
);

CREATE TABLE movies (
    movie_id INT(11) PRIMARY KEY,
    title VARCHAR(45),
    length INT(11),
    plot TEXT,
    release_year INT(11),
    genre_genre_id INT(11),
    FOREIGN KEY (genre_genre_id) REFERENCES genre(genre_id)
);


CREATE TABLE inventory_copies (
    copy_id INT(11) PRIMARY KEY,
    movies_movie_id INT(11),
    available TINYINT(1),
    FOREIGN KEY (movies_movie_id) REFERENCES movies(movie_id) ON DELETE CASCADE
);

CREATE TABLE rentals (
    rental_id INT(11) PRIMARY KEY,
    rental_date DATE,
    due_date DATE,
    inventory_copies_copy_id INT(11),
    users_user_id INT(11),
    FOREIGN KEY (inventory_copies_copy_id) REFERENCES inventory_copies(copy_id),
    FOREIGN KEY (users_user_id) REFERENCES users(user_id)
);

CREATE TABLE directors (
    director_id INT PRIMARY KEY AUTO_INCREMENT,
    director_name VARCHAR(100) NOT NULL,
    director_birthdate DATE
);

CREATE TABLE movie_directors (
    movie_id INT,
    director_id INT,
    PRIMARY KEY (movie_id, director_id),
    FOREIGN KEY (movie_id) REFERENCES movies(movie_id),
    FOREIGN KEY (director_id) REFERENCES directors(director_id)
);


INSERT INTO address (address_id, street, city, country) VALUES
(1, '1 Infinite Loop', 'Cupertino', 'USA'),
(2, '1 Hacker Way', 'Menlo Park', 'USA'),
(3, '350 Fifth Avenue', 'New York', 'USA'),
(4, '221B Baker Street', 'London', 'UK'),
(5, 'P. Sherman, 42 Wallaby Way', 'Sydney', 'Australia');

INSERT INTO users (user_id, first_name, last_name, age, address_address_id) VALUES
(1, 'Steve', 'Jobs', 56, 1),
(2, 'Mark', 'Zuckerberg', 39, 2),
(3, 'Elon', 'Musk', 52, 1),
(4, 'Sherlock', 'Holmes', NULL, 4),
(5, 'Nemo', NULL, NULL, 5);

INSERT INTO genre (genre_id, genre_name) VALUES
(1, 'Biography'),
(2, 'Technology'),
(3, 'Mystery'),
(4, 'Animated'),
(5, 'Fantasy');

INSERT INTO movies (movie_id, title, length, plot, release_year, genre_genre_id) VALUES
(101, 'Steve Jobs', 122, 'The story of Steve Jobs.', 2015, 1),
(102, 'The Social Network', 120, 'The story of the founding of Facebook.', 2010, 2),
(103, 'The Prestige', 130, 'Two stage magicians engage in competitive one-upmanship.', 2006, 3),
(104, 'Finding Nemo', 100, 'After his son is captured in the Great Barrier Reef, a clownfish sets out on a journey to bring him home.', 2003, 4),
(105, 'Pokemon1', 90, 'A young boy with extraordinary abilities is tasked with saving the world from a mysterious organization.', 2024, 5);

INSERT INTO inventory_copies (copy_id, movies_movie_id, available) VALUES
(201, 101, 1),
(202, 102, 1),
(203, 103, 0),
(204, 104, 1),
(205, 105, 1);

INSERT INTO rentals (rental_id, rental_date, due_date, inventory_copies_copy_id, users_user_id) VALUES
(301, '2024-02-01', '2024-02-08', 201, 1),
(302, '2024-02-05', '2024-02-12', 202, 2),
(303, '2024-02-10', '2024-02-17', 203, 3),
(304, '2024-02-15', '2024-02-22', 204, 4),
(305, '2024-02-20', '2024-02-27', 205, 5);

INSERT INTO directors (director_name, director_birthdate) VALUES
('Danny Boyle', '1956-10-20'),
('David Fincher', '1962-08-28'),
('Christopher Nolan', '1970-07-30'),
('Andrew Stanton', '1965-12-03');

INSERT INTO movie_directors (movie_id, director_id) VALUES
(101, 1),
(102, 2),
(103, 3),
(104, 4),
(101, 3),
(102, 1),
(103, 2);


SELECT * FROM users WHERE first_name = 'Mark';
DELETE FROM movies WHERE title = 'Pokemon1';
SELECT * FROM genre ORDER BY genre_name ASC;
SELECT * FROM movies ORDER BY release_year DESC;
SELECT * FROM directors;
SELECT * FROM movie_directors;