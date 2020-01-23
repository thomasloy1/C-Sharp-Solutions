-- 1. Find all the Regions
select * from Region;


select RegionDescription from Region;

-- 2. Find all the Cities
select * from Territories;

select TerritoryDescription as Cities
       from Territories
	   order by Cities; 

-- 3. Find all the cities in the southern region
select * from Region;
select * from Territories;

select TerritoryID, TerritoryDescription
   from Territories
   where RegionID = 4;

   select TerritoryID, 
          TerritoryDescription,
		  'Southern' as Region
   from Territories
   where RegionID = 4;


--4. Run with fully qualified column name
select    dbo.Territories.TerritoryID, 
          TerritoryDescription,
		  'Southern' as Region
   from Territories
   where RegionID = 4;

--5. Run with Table Alias

select    T.TerritoryID, 
          TerritoryDescription,
		  'Southern' as Region
   from dbo.Territories as T
   where RegionID = 4;

--6. What is the contact name, telephone number, and city for each customer?
select     ContactName,
           Phone,
		   City
	from Customers
	order by ContactName;

--7. What are the products currently out of stock?
select * from Products;

Select    ProductName,
          UnitsInStock
	from Products
	where UnitsInStock = 0
	and Discontinued = 0
	order by ProductName;

--8. What are the ten products currently in stock with the least amount on hand?

Select top 10   ProductName,
                UnitsInStock
	     from Products
	     where UnitsInStock != 0
	     order by UnitsInStock asc;

--9. What are the five most expensive products in stock?

Select Top 5    ProductName,
                UnitPrice
			from Products
			where UnitsInStock != 0
			order by UnitPrice desc;

--10. How many products does Northwind have? How many customers? How many suppliers?

select count(*) as ProductID
			from Products

select count(*) as SupplierID
			from Suppliers

select count(*) as CustomerID
			from Customers