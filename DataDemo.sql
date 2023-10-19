CREATE TABLE productlist (
    productid INT,
    productname VARCHAR(255),
	unitinstock int
);

INSERT INTO productlist (productid, productname,unitinstock)
VALUES (1, N' Bánh mì',40),
       (2, N' Bánh bao',20),
       (3, N' Bánh tráng',15);


CREATE TABLE categories (
    productid INT,
    productname VARCHAR(255),

);
	   INSERT INTO categories (productid, productname)
VALUES (1, N' Bánh'),
       (2, N' Kẹo')
   