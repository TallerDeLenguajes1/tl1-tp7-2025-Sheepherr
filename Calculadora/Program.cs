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
bool continuar = true;

while (!esNum1)
{
    Console.WriteLine("El valor ingresado no es valido, por favor ingrese un numero valido");
    numero = Console.ReadLine();
    esNum1 = double.TryParse(numero, out num1);
}
MiCalculadora.Sumar(num1);
Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
while (continuar)
{
    Console.WriteLine("1 Suma\n2 Resta\n3 Multiplicar\n4 Dividir\nIngrese la operacion que desea realizar: ");
    numero = Console.ReadLine();
    int operacion;
    bool esnum1 = int.TryParse(numero, out operacion);
    while (operacion > 4 || !esnum1 || operacion == 0)
    {
        Console.WriteLine("El numero ingresado no es una operacion disponible, porfavor ingrese de nuevo un numero valido");
        numero = Console.ReadLine();
        esnum1 = int.TryParse(numero, out operacion);
    }
    while (operacion != 0)
    {
        Console.WriteLine("Ingrese el numero para realizar la operacion");
        numero = Console.ReadLine();
        esNum1 = double.TryParse(numero, out num1);
        while (!esNum1)
        {
            Console.WriteLine("El valor ingresado no es valido, porfavor ingrese un numero valido");
            numero = Console.ReadLine();
            esNum1 = double.TryParse(numero, out num1);
        }
        switch (operacion)
        {
            case 1: 
                MiCalculadora.Sumar(num1);
                Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
                break;
            case 2: 
                MiCalculadora.Restar(num1);
                Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
                break;
            case 3: 
                MiCalculadora.Multiplicar(num1);
                Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
                break;
            case 4:
                MiCalculadora.Dividir(num1);
                Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
                break;
        }
        Console.WriteLine($"Resultado: {MiCalculadora.Resultado}");
        Console.WriteLine("Si desea realizar otra operacion ingrese cual.\n1 Suma\n2 Resta\n3 Multiplicar\n4 Dividir\n0 Limpiar");
        numero = Console.ReadLine();
        esnum1 = int.TryParse(numero, out operacion);
        while (operacion > 4 || !esnum1)
        {
            Console.WriteLine("El numero ingresado no es una operacion disponible, porfavor ingrese de nuevo un numero valido");
            numero = Console.ReadLine();
            esnum1 = int.TryParse(numero, out operacion);
        }

    }
    MiCalculadora.Limpiar();
    Console.WriteLine("¿Desea realizar otro calculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    continuar = (respuesta == "s");
    if (respuesta == "s")
    {
        Console.WriteLine("Ingrese un numero: ");
        numero = Console.ReadLine();
        esNum1 = double.TryParse(numero, out num1);
        while (!esNum1)
        {
            Console.WriteLine("El valor ingresado no es valido, por favor ingrese un numero valido");
            numero = Console.ReadLine();
            esNum1 = double.TryParse(numero, out num1);
        }
    }

}


