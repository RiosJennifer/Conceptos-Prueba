﻿// See https://aka.ms/new-console-template for more information
using Conceptos_POO;
using ConceptosPOO;

Console.WriteLine("Conceptos POO");
Console.WriteLine("========================");
Employees employee1 = new SalaryEmpleyee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary= 1815453.45M
};
Console.WriteLine(employee1);

Employees employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales=320000000M,
    CommissionPercentaje=0.03F
};
Console.WriteLine(employee2);