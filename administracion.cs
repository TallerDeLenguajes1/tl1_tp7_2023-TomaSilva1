using System;
using recursos;

DateTime Fecha = DateTime.Today;

Empleado[] empleados = new Empleado[3];

int opc;
double totalSalarios;
totalSalarios = 0;
    
for (int i = 0; i < 3; i++)
    {
        empleados[i] = new Empleado();

        Console.WriteLine("Ingrese el nombre del empleado: ");
        empleados[i].Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el apeliido: ");
        empleados[i].Apellido = Console.ReadLine(); 
        Console.WriteLine("Estado civil: ");
        empleados[i].ECivil = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese fecha de nacimiento (dd/mm/yyyy): ");
        string aux = Console.ReadLine();
        empleados[i].Cumpleaños = DateTime.ParseExact(aux,"dd/MM/yyyy", null);
        Console.WriteLine("Ingrese su genero: ");
        empleados[i].Genero = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la fecha de ingreso a la empresa: ");
        string aux2 = Console.ReadLine();
        empleados[i].IngresoEmpresa = DateTime.ParseExact(aux2, "dd/MM/yyyy", null);
        Console.WriteLine("Ingrese su sueldo basico: ");
        empleados[i].SueldoB = double.Parse(Console.ReadLine());
        empleados[i].Edad = Fecha.Year - empleados[i].Cumpleaños.Year;
        empleados[i].Antiguedad = Fecha.Year - empleados[i].IngresoEmpresa.Year;
        Console.WriteLine("Ingrese su cargo: ");
        Console.WriteLine("(1)Auxiliar");
        Console.WriteLine("(2)Administrativo");
        Console.WriteLine("(3)Ingeniero");
        Console.WriteLine("(4)Especialista");
        Console.WriteLine("(5)Investigador");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1: empleados[i].Cargo = cargos.Auxiliar; 
            break;
            case 2: empleados[i].Cargo = cargos.Administrativo;
            break;
            case 3: empleados[i].Cargo = cargos.Ingeniero;
            break;
            case 4: empleados[i].Cargo = cargos.Especialista;
            break;
            case 5: empleados[i].Cargo = cargos.Investigador;
            break;
            
        }
        
        switch (empleados[i].Genero)
        {
            case 'M': empleados[i].Antiguedad = 65 - empleados[i].Edad;
            break;
            case 'F': empleados[i].Antiguedad = 60 - empleados[i].Edad;
            break;
        }

        if (empleados[i].Antiguedad <= 20)
        {
            empleados[i].Adicional = empleados[i].SueldoB*(empleados[i].Antiguedad/10);
        }else{
            empleados[i].Adicional = empleados[i].SueldoB*0.25;
        }

        if (empleados[i].Cargo == cargos.Ingeniero || empleados[i].Cargo == cargos.Especialista)
        {
            empleados[i].Adicional *= 1.5;
        }

        if (empleados[i].ECivil == 'C')
        {
            empleados[i].Adicional += 15000;
        }

        empleados[i].Salario = empleados[i].SueldoB + empleados[i].Adicional;

        totalSalarios += empleados[i].Salario;
    }


    

        
        