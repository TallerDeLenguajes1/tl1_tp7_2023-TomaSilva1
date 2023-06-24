using Calculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int salir;
int opc;
int num1;
num1 = 0;
salir = 1;

Calculador item = new Calculador();

Console.WriteLine("Ingrese un numero: ");
item.Resultado = double.Parse(Console.ReadLine());

while (salir != 0)
{
    Console.WriteLine("Calculadora: (1)Suma, (2)Resta, (3)Producto, (4)Cociente, (5)Limpiar :");
    opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1: 
            Console.WriteLine("Ingrese cuanto quiere sumar: ");
            num1 = int.Parse(Console.ReadLine());
            item.Resultado = item.Sumar(num1);
             
        break;
        case 2:
            Console.WriteLine("Ingrese cuanto quiere Restar: ");
            num1 = Console.Read();
            item.Resultado = item.Restar(num1);
        break;
        case 3:
            Console.WriteLine("Ingrese por cuanto lo quiere multiplicar: ");
            num1 = Console.Read();
            item.Resultado = item.Producto(num1);
        break;
        case 4:
            Console.WriteLine("Ingrese por cuanto lo quiere dividir: ");
            num1 = Console.Read();
            item.Resultado = item.Cociente(num1);
        break;
        case 5:
        break;
    }
    Console.WriteLine("Ingrese (0) Para salir.");
    salir = int.Parse(Console.ReadLine());
}
    
 

