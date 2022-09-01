-- create table Category
-- (
--     category_id   int identity
--         constraint Category_pk
--         primary key,
--     category_name nvarchar(max) not null
-- )
--     go
-- 
-- create unique index Category_category_id_uindex
--     on Category (category_id)
--     go
-- 
-- create table Product
-- (
--     product_id   int identity
--         constraint Product_pk
--         primary key,
--     product_name nvarchar(max) not null
-- )
--     go
-- 
-- create unique index Product_product_id_uindex
--     on Product (product_id)
--     go
-- 
-- create table Product_Category
-- (
--     id          int identity
--         constraint Product_Category_pk
--         primary key,
--     product_id  int not null
--         constraint Product_Category_Product_product_id_fk
--             references Product
--             on update cascade on delete cascade,
--     category_id int not null
--         constraint Product_Category_Category_category_id_fk
--             references Category
--             on update cascade on delete cascade
-- )
--     go
-- 
-- create unique index Product_Category_id_uindex
--     on Product_Category (id)
--     go

SELECT P.product_name, C.category_name
FROM Product_Category
JOIN Category C on Product_Category.category_id = C.category_id
RIGHT JOIN Product P on Product_Category.product_id = P.product_id