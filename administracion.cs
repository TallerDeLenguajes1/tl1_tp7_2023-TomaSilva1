using System;
using recursos;


Empleado[] empleados = new Empleado[3];

    
for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Ingrese el nombre del empleado: ");
        empleados[i].Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apeliido: ");
        empleados[i].Apellido = Console.ReadLine(); 
        Console.WriteLine("Estado civil: ");
        empleados[i].ECivil = char.Parse(Console.ReadLine());
    }