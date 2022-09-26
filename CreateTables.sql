USE GrindGo
GO

CREATE TABLE adminClass.CUSTOMER
(
customer_ID int IDENTITY (1,1) primary key,
firstName varchar(15),
lastName varchar(20),
residentAddress varchar(100),
emailAddress varchar(25),
c_password varchar(30),
loyalty_Qty int
)

CREATE TABLE adminClass.STAFF
(
staff_ID int IDENTITY (1,1) primary key,
firstName varchar(15),
lastName varchar(20),
id_Num char(13),
dateOfBirth date,
residentAddress varchar(100),
username varchar(15),
s_password varchar(30)
)

CREATE TABLE adminClass.ORDERS
(
order_ID int IDENTITY (1,1) primary key,
order_Time time,
order_Date date,
order_Total decimal,
staff_ID int foreign key REFERENCES adminClass.STAFF (staff_ID),
customer_ID int foreign key REFERENCES adminClass.CUSTOMER (customer_ID)
)

CREATE TABLE adminClass.STOCK
(
stock_ID int IDENTITY (1,1) primary key,
stock_desc varchar(15),
stock_costPrice decimal
)

CREATE TABLE adminClass.CONSUMABLE
(
consumable_ID int IDENTITY (1,1) primary key,
stock_ID int foreign key REFERENCES adminClass.STOCK (stock_ID),
stock_sellPrice decimal,
order_ID int foreign key REFERENCES adminClass.ORDERS (order_ID),
withMilk bit,
milkType varchar(10),
withFroth bit
)
