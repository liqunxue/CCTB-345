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
group cust by cust.City
into custGroup
where custGroup.Count() >2
orderby custGroup.Key
select custGroup