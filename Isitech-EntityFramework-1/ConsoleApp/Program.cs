﻿// See https://aka.ms/new-console-template for more information

using EFCore.Shared;

Console.WriteLine("Hello, World!");

Northwind db = new();
Console.WriteLine($"Nom du provider: {db.Database.ProviderName}");

//Program_Queries.GetCategories();

Console.WriteLine("Entrez un prix :");
String price = Console.ReadLine();

ProgramQueries.GetProductsByPriceSuperior(decimal.Parse(price));