// See https://aka.ms/new-console-template for more information
using System.Configuration;

Console.WriteLine("Hello, World!");

string connectionString = ConfigurationManager.ConnectionStrings["demodb"].ConnectionString;