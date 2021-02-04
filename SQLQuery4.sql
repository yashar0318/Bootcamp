--Select 
--ANSI Standart

Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

select * from Products where CategoryID  = 1 or CategoryID = 3 

select * from Products where CategoryID  = 1 and  UnitPrice>=10

select * from Products where CategoryID = 1 order by UnitPrice desc --ascending asc --descending desc

select Count(*) Sayi from Products 

select CategoryID,Count(*)  from Products where UnitPrice>=10 group by CategoryID

select  Products.CategoryID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
order by UnitPrice 


Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o  -- left join olanda solda var sagda yoxdu inner join olanda ise her ikisinde olandi.Yeni ki inner vasitesile nese alanlar gorsenir,left vasitesile almayanda gorsenir(2:35)
on c.CustomerID = o.CustomerID
where o.CustomerID is null





