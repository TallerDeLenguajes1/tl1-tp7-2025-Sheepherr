// See https://aka.ms/new-console-template for more information
using System;
using EspacioSisPersonal;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado()
{
    Nombre = "Lucia",
    Apellido = "Ramirez",
    FechN = new DateTime(1990, 4, 12),
    EstadoCivil = 'c',
    FechIng = new DateTime(2010, 6, 1),
    CargoEmpleado = Cargo.Ingeniero,
};
empleados[0].CalcularSueldo(350000m);

empleados[1] = new Empleado()
{
    Nombre = "Carlos",
    Apellido = "Juarez",
    FechN = new DateTime(1985, 9, 30),
    FechIng = new DateTime(2004, 4,17),
    CargoEmpleado = Cargo.Administrativo
};
empleados[1].CalcularSueldo(320000m);

empleados[2] = new Empleado()
{
    Nombre = "Marina",
    Apellido = "González",
    FechN = new DateTime(2001, 1, 5),
    EstadoCivil = 'c',
    FechIng = new DateTime(2024, 1, 10),
    CargoEmpleado = Cargo.Especialista
};
empleados[2].CalcularSueldo(290000m);

foreach (Empleado emp in empleados)
{
    Console.WriteLine($"Nombre: {emp.Nombre} {emp.Apellido}");
    Console.WriteLine($"Edad: {emp.Edad}");
    Console.WriteLine($"Fecha de nacimiento: {emp.FechN}");
    Console.WriteLine($"Fecha de ingreso: {emp.FechIng}");
    Console.WriteLine($"Antigüedad: {emp.Antiguedad}");
    Console.WriteLine($"Años para jubilarse: {emp.Jubil}");
    Console.WriteLine($"Cargo: {emp.CargoEmpleado}");
    Console.WriteLine($"Sueldo: {emp.Sueldo:C}");
    Console.WriteLine("------------------------");
}