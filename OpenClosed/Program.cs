﻿// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");

/*
 * Bir nesne (hatta tüm yazılım varlıkları), 
 * .......gelişime.........AÇIK........değişime..........KAPALI olmalıdır.
 */

OrderManagement orderManagement = new OrderManagement();
Customer customer = new Customer() { Name = "Furkan", Card = new PremiumCard() };
orderManagement.Customer = customer;
Console.WriteLine(orderManagement.GetDiscountedPrice(1000));