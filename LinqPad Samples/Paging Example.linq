<Query Kind="Expression">
  <Connection>
    <ID>d201c54f-e17a-43dd-9d3d-459142fc7b9b</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

(from anItem in Customers
orderby  anItem.ContactName
select anItem).Skip(5).Take(3)