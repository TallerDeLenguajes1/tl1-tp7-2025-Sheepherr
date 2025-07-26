// See https://aka.ms/new-console-template for more information
using System.Timers;
using EspacioCalculadora;


//Ejercicio 1
Calculadora MiCalculadora = new Calculadora();

Console.WriteLine("==========CALCULADORA============");

Console.WriteLine("Ingrese un numero: ");
string numero = Console.ReadLine();
double num1;
bool esNum1 = double.TryParse(numero, out num1);

while (!esNum1)
{
    Console.WriteLine("El valor ingresado no es valido, por favor ingrese un numero valido");
    numero = Console.ReadLine();
    esNum1 = double.TryParse(numero, out num1);
}
MiCalculadora.Sumar(num1);
Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");

Console.WriteLine("1 Suma\n2 Resta\n3 Multiplicar\n4 Dividir\nIngrese la operacion que desea realizar: ");
numero = Console.ReadLine();
int operacion;
bool esnum1 = int.TryParse(numero, out operacion);
while (operacion > 4 || !esnum1)
{
    Console.WriteLine("El numero ingresado no es una operacion disponible, porfavor ingrese de nuevo un numero valido");
    numero = Console.ReadLine();
    esnum1 = int.TryParse(numero, out operacion);
}


