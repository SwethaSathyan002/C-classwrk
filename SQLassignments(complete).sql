create database CompanyDB
use CompanyDB
 --create table
Create table Employee(
 Employee_ID int NOT NULL PRIMARY KEY,
 FirstName varchar(50),
 LastName varchar(50),
 Department varchar(50),
 Salary int,


);

truncate table Employee
--insert values
INSERT into Employee(Employee_ID,FirstName,LastName,Department,Salary)
values
(1,'John', 'Doe', 'HR', 50000),
(2,'Jane', 'Smith', 'IT' , 60000),
(3, 'David' ,'Lee', 'Marketing', 55000)

--retrieve all data of table

SELECT * FROM Employee 
--retrieve firstname lastname and salary from employee where dept is it and sal>50000
select FirstName, LastName, Salary from Employee where Department='IT' and Salary>50000

--retrieve max salary

select max(Salary) as MaxSalary from Employee

--salary updated
update Employee set Salary = 55000 where FirstName='John' and LastName='Doe'


--department updated
update Employee set Department = 'Marketing' where FirstName='Jane' and LastName='Smith'


--delete david lee

delete from Employee where FirstName='David' and LastName= 'Lee'

--delete ppl of marketing

delete from Employee where Department='Marketing'





--------assignment 6-----------------

--created table
Create table Products(
    ProductID int not null Primary key,
	ProductName varchar(50),
	Category varchar(50),
	Price int,
	Stock int,
)

--inserted values 
insert into Products(ProductID,ProductName,Category,Price,Stock)
values
(1, 'Laptop','Electronics',1000,50),
(2,'Mouse','Electronics',20, 200),
(3,'Keyboard','Electronics',30,150),
(4,'Printer','Electronics',150,75)

--selected all columns
select * from Products

---ascending order by price
select*from Products
order by Price desc

--update price of mouse to 25
update Products set Price = 25 where ProductName='Mouse'

--delete mouse
delete from Products where ProductID = 2

--alphabetical order
select*from Products
order by ProductName asc



----------assignment 7---------------
--crreated table
create table Books(
BookID int not null Primary key,
Title varchar(255),
Author varchar(255),
PublishedYear int,
AvailableCopies int,


);
--inserted values
insert into Books (BookID,Title,Author,PublishedYear,AvailableCopies)
values
(1,'The Great Gatsby','F.Scott Fitzgerald',1925,3),
(2,'1984','George Orwell', 1949,2),
(3,'To Kill a Mockingbird','Harper Lee', 1960,5),
(4,'Brave New World','Aldous Huxley', 1932,4)



---update available copies to 5
update Books set AvailableCopies=5 where Title='1984'

--delete bookid 1
delete from Books where BookID=1

--select books published after 1950
select*from Books where PublishedYear>1950


-----------assignment 8--------------

----created table
create table Customers(
CustomerID int not null,
CustomerName varchar(255),
Email varchar(255),
PhoneNumber varchar(255),
);

--values inserted
insert into Customers(CustomerID,CustomerName,Email,PhoneNumber)
values
(201,'Alice Johnson', 'alice@example.com','555-1234'),
(202,'Bob Smith', 'bob@example.com','555-5678'),
(203,'Charlie Brown', 'charlie@example.com','555-8765')

select*from Customers

--added a customer
insert into Customers(CustomerID,CustomerName,Email,PhoneNumber)
values
(204,'David Wilson', 'david@example.com','555-4321')

---updated phone number
update Customers set PhoneNumber='555-9999' where CustomerName = 'Alice Johnson'

--*deleted customer 202
Delete from Customers where CustomerID = 202


--------------------assignment 9--------------
---create table
create table Orders
(
 OrderID int primary key,
 CustomerID int ,
 OrderDate date,
 TotalAmount decimal(10,2),
);


---insert values
insert into Orders (OrderID,CustomerID,OrderDate,TotalAmount)
values
(301,201,'2024-09-01',250.00),
(302,202,'2024-09-02',150.00),
(303,203,'2024-09-03',200.00)

select*from Orders

---insert one order
insert into Orders (OrderID,CustomerID,OrderDate,TotalAmount)
values
(304,204,'2024-09-04',300.00)


--update total amount 
update Orders set TotalAmount=275.00 where OrderID=301

--delete order of id 302
delete from Orders where OrderID = 302

---select Total amount >200
select * from Orders where TotalAmount>200

---select orderid and total amount
select OrderID, TotalAmount from Orders 



-------------assignment 10-------------

create table students(
StudentID int primary key identity(1,1),
FirstName varchar(255),
LastName varchar(255),
Email varchar(255),
);
select*from students
insert into students (FirstName, LastName,Email)
values
( 'John', 'Doe', 'john.doe@example.com'),
( 'Jane', 'Smith', 'jane.smith@example.com'),
( 'Mike', 'Johnson', 'mike.johnson@example.com');


----------assignment 11------------

create table Course(
CourseID int primary key,
CourseName varchar(255),
);


create table enrolments(
StudentID int,
CourseID int,
foreign key(StudentID) references  students(StudentID),
foreign key(CourseID) references Course(CourseID)

);


-----------12---------
create table OrderDetails (
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT,
    PRIMARY KEY (OrderID, ProductID)
);

select*from OrderDetails

-------------13-------------

create table Users (
    UserID INT NOT NULL PRIMARY KEY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Username VARCHAR(255) NOT NULL,
    CONSTRAINT username_unique UNIQUE (Username)
);
select*from Users


---------15
CREATE TABLE NKEmployees (
    SSN CHAR(9) NOT NULL PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Position VARCHAR(50)
);



------------16----------


create table UkCustomer(
CustomerID int primary key,
PhoneNo int unique,
);









--------assignment 17----------

-----create view
create view EmployeeView
as
select FirstName, LastName, Department from Employee

----display employeeview
select*from EmployeeView


--------assignment 18------
--create view
create view EditableEmployeeView
as
select Employee_ID, FirstName,LastName, Salary from Employee

--update salary
update EditableEmployeeView
set Salary = 750000
where Employee_ID = 1

----verify employ
select*from EditableEmployeeView
where Employee_ID=1


------assignment 19-------

--create view 
create view EmployeeSalaryBonusView
as
select FirstName, LastName, Salary, Salary*0.10 as Bonus from Employee
----verify
select*from EmployeeSalaryBonusView


-----assignment 20-----
---alter employeeview created first
alter view EmployeeView
as
Select FirstName,LastName,Department,Salary
from Employee

----verify
select*from EmployeeView

-------assignment 21-----

-----create view
create view FilteredEmployeeView
as
select Employee_ID,FirstName,LastName,Department
from Employee

----return employees in a specific department
select *from FilteredEmployeeView where Department='HR'

------assignment 22--------
---drop view
drop view EmployeeView

-----verify
select * from EmployeeView





----------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------



-----------1---------------

--table created
create table Sales(
SaleID int primary key,
ProductID int,
ProductName varchar(255),
QuantitySold int,
SaleAmount int,
SaleDate date,
);

---inserted values
insert into Sales(SaleID,ProductID,ProductName,QuantitySold,SaleAmount,SaleDate)
values
(1,101,'Laptop',5,5000,'2024-09-01'),
(2,102,'Mouse',10,250,'2024-09-02'),
(3,101,'Laptop',3,3000,'2024-09-03'),
(4,103, 'Keyboard', 8, 800, '2024-09-04'),
(5, 102, 'Mouse', 6, 150, '2024-09-05')

---view table
select*from Sales

 ----sum calculated
select sum(SaleAmount) as TotalSaleAmount from Sales

----max calculated
select max(QuantitySold) as maximumquantitysold from Sales

-----average of saleamount
select avg(SaleAmount) as average from Sales

------min calculated
select min(SaleAmount) as minsaleamount from Sales

---sum of quantity sold of laptop
select sum(QuantitySold) as totalquantitysold from Sales where ProductName='Laptop'




-------assignment 2---------

---created table
create table EmployeeSalaries(

EmployeeID int primary key,
EmployeeName varchar(255),
Department varchar(255),
Salary int,
HireDate date,
);

----inserted values
insert into EmployeeSalaries (EmployeeID,EmployeeName,Department,Salary,HireDate)
values
(1, 'John Doe', 'IT', 5000, '2022-01-10'),
(2, 'Jane Smith', 'HR', 6000, '2021-03-15'),
(3, 'Bob Johnson', 'Finance', 5500, '2020-06-20'),
(4, 'Alice Brown', 'IT' ,6200, '2023-02-01'),
(5, 'Charlie White', 'Marketing', 4800, '2023-03-10')

select*from EmployeeSalaries


--total salary expenditure
select sum(Salary) as expenditure from EmployeeSalaries

---highest salary------
select max(Salary) as highest from EmployeeSalaries

-----average salary------

select avg(Salary) as average from EmployeeSalaries


-------min salary in IT dept
select min(Salary) as minofIT from EmployeeSalaries where Department = 'IT'


------employees grouped by dept
select Department, count(EmployeeID) as countofemployees from EmployeeSalaries
group by Department
order by countofemployees



------assignment 3-------

create table Inventory(
ProductID int ,
ProductName varchar(255),
QuantityInStock int,
ReorderLevel int,
LastRestockDate date,
);
 
insert into Inventory (ProductID,ProductName,QuantityInStock,ReorderLevel,LastRestockDate)
values
(201, 'Monitor', 50, 10, '2024-08-25'),
(202, 'Printer', 30, 5, '2024-09-01'),
(203, 'Mouse' ,100, 15, '2024-09-10'),
(204, 'Keyboard' ,80, 20, '2024-09-15'),
(205, 'Laptop', 25, 5, '2024-09-20')

select*from Inventory

----find the total quantity of products in stock (SUM).

select sum(QuantityInStock) as totalquantity from Inventory


----find the product with the highest quantity in stock

select ProductName,QuantityInStock from Inventory where QuantityInStock =(select max(QuantityInStock) from Inventory )

----find the average reorder level across all products

select avg(ReorderLevel) as average from Inventory

----find the product with the lowest reorder level

select ProductName, ReorderLevel from Inventory where ReorderLevel = (select min(ReorderLevel) from Inventory)


-----find the total quantity in stock for products where the quantity is less than the reorder level
 select sum(QuantityInStock) as totalstock from Inventory where QuantityInStock<ReorderLevel




 ------------assignment 4------------

 create table CustomerOrders(
 OrderID int,
 CustomerID varchar(100),
 OrderDate date,
 OrderAmount int,
 QuantityOrdered int
 );


 insert into CustomerOrders (OrderID,CustomerID,OrderDate,OrderAmount,QuantityOrdered)
 values
 (501, 'C001', '2024-09-10', 1500, 3),
(502, 'C002', '2024-09-11', 2000, 5),
(503, 'C001', '2024-09-12', 1000, 2),
(504, 'C003', '2024-09-13', 2500, 4),
(505, 'C002', '2024-09-14', 3000, 6)

select*from CustomerOrders

-----total order amount for all orders
select sum(OrderAmount) as totalamount from CustomerOrders


----average order amount for all customers

select avg(OrderAmount) as average from CustomerOrders



------maximum order amount from a single order

select max(OrderAmount) as maxamount from CustomerOrders

------the total quantity ordered across all orders

select sum(QuantityOrdered) as totalquantity from CustomerOrders

-----the minimum order amount in the database

select min(OrderAmount) from CustomerOrders




---------------assignment6------

create table ProductRating(
RatingID int,
ProductID varchar(255),
CustomerID varchar(255),
Rating int,
ReviewDate date,
);

insert into ProductRating (RatingID,ProductID,CustomerID,Rating,ReviewDate)
values
(1,'P001', 'C001', 4, '2024-09-01'),
(2, 'P002', 'C002', 5, '2024-09-02'),
(3, 'P001', 'C003' ,3, '2024-09-03'),
(4, 'P003', 'C001', 2, '2024-09-04'),
(5, 'P002', 'C004', 4, '2024-09-05')

select*from ProductRating


----average rating for each product

select ProductID, avg(Rating) as average from ProductRating
group by ProductID

---the highest rating given to any product

select max(Rating) as highest_rating from ProductRating

---the lowest rating given to any product

select min(Rating) as lowest_rating from ProductRating


------the total number of ratings for each product
select ProductID, count(Rating) as total_numbr_of_rating from ProductRating
Group by ProductID


-----total number of products rated

select count(distinct ProductID) as Products_rated from ProductRating


-----------------------------------------------------------------------------------------------------------------------


--------1--------------

---of employees who work in either the 'HR', 'Finance', or 'IT' departments.
select*from Employee where Department in ('HR','Finance','IT')

----------2-----------

---Retrieve the product names and prices of products that are priced between 100 and 500.

select*from Products where Price between 100 and 500

----------3---------------
---Retrieve the customer names that start with the letter 'A'.

select*from Customers where CustomerName like 'A%'

----------4------------------------
----Retrieve the order IDs of orders placed on '2023-01-01', '2023-02-01', and '2023-03-01'.

create table Orderin(
OrderID int,
OrderDate date,
);

insert into Orderin (OrderID,OrderDate)
values
(1,'2023-02-03'),
(2,'2023-01-01'),
(3,'2023-03-01')


select OrderID from Orderin where OrderDate in ('2023-01-01', '2023-02-01',  '2023-03-01')

-----------5---------------
--Retrieve the product names and prices of products that are not priced between 100 and500.

select*from Products where Price not between 100 and 500


-----------6---------------
--Retrieve the order IDs where the total amount is either greater than 5000 or less than 1000.

select OrderID from CustomerOrders where OrderAmount>5000 or OrderAmount<1000



---------7-----------
----Retrieve the names of employees who do not work in the 'HR' or 'IT' departments.

select FirstName,LastName from Employee where Department not in ('HR','IT')


---------8----------
----Retrieve the order IDs of orders placed between '2023-01-01' and '2023-12-31'.

select OrderID from Orderin where OrderDate between '2023-01-01' and '2023-12-31'

---------9----------
----Retrieve the customer names that do not have 'John' in them.

select CustomerName from Customers where CustomerName not like '%John%'


--------10---------
----Retrieve the product names and prices of products that are either in category 'A' or have a price less than 100.

CREATE TABLE Categories (
CategoryID INT PRIMARY KEY,
CategoryName VARCHAR(50) NOT NULL
);

insert into Categories
values(1, 'A'),
(2,'B')

Alter table Products
add CategoryID int

update Products
set CategoryID = 2 where ProductName='Printer'


 select ProductName, Price from Products where Price<100 or CategoryID = (select CategoryID from Categories where CategoryName='A')

 -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
 ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



 -----------1---------------
 ---add column 
 alter table Employee
 add DateOfBirth date


 select*from Employee


 ------------2--------------
 -----modify column data type

 create table ModifyCustomers(
 CustomerID int,
 PhoneNumbr int,
 );

 alter table ModifyCustomers
 alter column PhoneNumbr varchar(250)

 select*from ModifyCustomers
 insert into ModifyCustomers
 values(1,4560),(2,5236)



 -------------3--------------
 ------add primary key

 create table Department (
 DepartmentID int not null,
 DepartmentName varchar(100),
 );




 alter table Department
 add constraint Pk_Department primary key (DepartmentID);


 ---------------4---------------
 ---drop column

 --added a column
 Alter table Employee
 add MiddleName varchar(100)

 --verify
 select*from Employee

 ---remove a column

 alter table Employee
 drop Column MiddleName


 -------5---------
 ---add foreign key

 --add column Employ_ID in orders table
 alter table orders
 add Employee_ID int 

 -----add Employee_ID as foreign key 
 Alter table Orders
 add constraint Fk_Employee foreign key (Employee_ID) references Employee(Employee_ID)


 --------6---------
 -----drop Forign key

 alter table orders
 drop constraint Fk_Employee



 ---------7---------
 -----rename column firstname to employee first name in employees table

 exec sp_rename 'Employee.FirstName','EmployeeFullName','COLUMN';

 ---------8-------------
 -----add default value

 alter table Employee
 add Status varchar(100)

 select*from Employee

 alter table Employee
 add constraint DF_Status
 default 'Active' for Status

 insert into Employee
 values (4,'kelly','quinn','Marketing',523614,'2002-03-01',default)


 -----------9---------
 -----drop primary key


 Alter table Department
 drop constraint Pk_Department


 -----------10--------------
 -----add unique key

 alter table Employee
 add email varchar (255)

 select*from Employee

 alter table Employee
 add constraint UO_email unique (email)


 ---------11----------

 alter table Employee
 add constraint Ck_salary check (salary>=1000)


 ---------12------------
 alter table Employee
 drop constraint Ck_salary


 ------------------------------------------------------------------------------------------------------------------------


 -----------1--------

 select FirstName from Employee where Salary>( select avg(Salary) from Employee)


 select*from Employee


 ----------2------------
 ---Retrieve the department names that have more than 5 employees.
 
  insert into Employee
 values (8,'heily','parker','Marketing',523614,'2002-03-01')


select DepartmentName from Department where DepartmentID in (select DepartmentID from Employee group by DepartmentID having COUNT(Employee_ID) > 5 )

-----------3-------------

----Retrieve Products with a Price Higher Than the Maximum Price of Category 'A'

select*from Products

select ProductName, Price from Products where Price >(select max(price) from Products where Category='A')



-----------4----------------

select*from Department
select*from Employee
----Retrieve the names of employees who work in departments where the average salary is higher than 50,000.

select FirstName from Employee 
where DepartmentID in

(select DepartmentID from Employee 
group by DepartmentID
having avg(Salary) > 50000 )


----------5------------
--Retrieve the names of employees who earn more than the average salary of their department.

SELECT Firstname
FROM Employee
WHERE Salary > 
(SELECT AVG(Salary)
FROM Employee
where DepartmentID = Employee.DepartmentID
);


----------6-------------
------Retrieve the names of customers who have not placed any orders.


select*from Customers
select*from orders

select CustomerName from Customers where CustomerID not in (select CustomerID from Orders)



--------7---------
-----Retrieve the names of products that have never been ordered.

----Products (ProductID, ProductName)
-----OrderDetails (OrderID, ProductID)

select*from Products
select*from OrderDetails

select ProductName from Products 
where ProductId not in (select ProductID from OrderDetails)

------------------------------------------------------------------------------------------------------------------------------------


---------1-----------------
----Retrieve the employee names and their corresponding department names.


select*from Employee
select*from Department


 
 select Employee.FirstName, Department.DepartmentName
from Employee inner join Department on Employee.DepartmentID = Department.DepartmentID;


----------------------------------------

---Retrieve the employee names and their corresponding department names. Include employees who are not assigned to any department.

select*from Employee
select*from Department

 select Employee.FirstName, Department.DepartmentName 
 from Employee LEFT JOIN Department on Employee.DepartmentID = Department.DepartmentID;




 -----------3-------------
 --Retrieve all departments and their respective employees. Include departments even if they don’t have any employees.

 select*from Employee
select*from Department
 select Department.DepartmentName, Employee.FirstName
 from Employee right join Department on Employee.DepartmentID = Department.DepartmentID;



 ----------4-------------
 ------Retrieve all employees and all departments, including employees without a department and departments without employees.

 select Employee.FirstName, Department.DepartmentName 
 from Employee FULL OUTER JOIN Department on Employee.DepartmentID = Department.DepartmentID;




 ---------5-------------
 
 ------Retrieve order ids and customer name for all orders 
 
 select*from orders
 select*from Customers
 select Orders.OrderID, Customers.CustomerName
 from Orders inner join Customers on Orders.CustomerID =Customers.CustomerID


 ----------6---------------
 ----------Retrieve all customers and their respective orders. Include customers even if they haven’t placed any orders.
  select*from orders
 select*from Customers

  select Orders.OrderID, Customers.CustomerName
 from Customers left join Orders on Customers.CustomerID = Orders.CustomerID 



 -------------7-------------


 ------Retrieve product names and their respective category names.

 select*from Products
 select*from Categories

 select Products.ProductName, Categories.CategoryName 
 from Products inner join Categories on Products.CategoryID = Categories.CategoryID



 ---------8-------------
 ----Retrieve all categories and the products in each category. Include categories that don’t have any products.

  select Products.ProductName, Categories.CategoryName 
 from Products right join Categories on Products.CategoryID = Categories.CategoryID



 ---------9-------------
 ------Retrieve the employee names and the names of their managers.

 select*from Employee
 alter table Employee
 add ManagaerID int

 select E.FirstName as Employee, m.FirstName as Manager
 from Employee E left join Employee m on E.ManagaerID = m.Employee_ID


 --------10-----------
 -----Task: Retrieve all possible combinations of products and orders (cartesian product).

 select*from Orders
 select*from Products

 select P.ProductID, P.ProductName, O.OrderID
 from Products P cross join Orders O 
 
 ----------------------------------------------------------------------------------------------------------------------------------------------------------------

  ------------1-----------
  --Retrieve the department name and the average salary of employees in each department. Only display departments where the average salary is greater than 50,000.

  select*from Employee
  select*from Department

 select Department.DepartmentName, avg(Employee.Salary) as avg_salary
 from Department join Employee on Department.DepartmentID =Employee.Employee_ID
 group by Department.DepartmentName 
 having avg(Employee.Salary)>55000


 -------------2-----------
 ---Retrieve the department name and the total number of employees in each department. Only display departments that have more than 5 employees. 

select  d.departmentname,count(*) as emp_count from Employee e inner join department d  on  e.departmentid= d.departmentid group by
d.departmentname  having count(*) > 0;

------------3------------
-- Retrieve the department name, maximum salary, and minimum salary for each department. Only include departments where the minimum salary is greater than 30,000.


select  d.departmentname,max(e.salary) as max_sal,min(e.salary) as min_sal from Employee e inner join department d  on  e.departmentid= d.departmentid group by
d.departmentname  having min(salary)> 30000 ;


------------4--------------
---retrieve the employee name and total sales made by each salesperson. Only display salespersons who have made total sales of more than 100,000. 

alter table sales
add employee_id int
select *  from employee;
select * from Sales;

select e.firstname ,sum(s.saleamount) as total_sales from employee e inner join Sales s on
e.employee_id=s.employee_id group by e.firstname;



-------------5---------------
-- Retrieve the customer name and the total number of orders placed by each customer. Only display customers who have placed more than 3 orders. 

select * from Customers;
select * from orders;


select  c.CustomerName  , count(*) as total_orders from customers c inner join 
orders o on c.customerid=o.CustomerId group by c.CustomerName ;