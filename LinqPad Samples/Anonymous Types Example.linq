<Query Kind="Expression">
  <Connection>
    <ID>d201c54f-e17a-43dd-9d3d-459142fc7b9b</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cust in Customers
select new 
{
	Name = cust.CompanyName,
	OrderCount = cust.Orders.Count,
	OrderDates = from anOrder in cust.Orders
				select anOrder.OrderDate
}