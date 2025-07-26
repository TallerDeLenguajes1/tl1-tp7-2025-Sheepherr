namespace EspacioCalculadora;
public class Calculadora
{
    private double dato;
    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        if (termino == 0)
        {
            Console.WriteLine("No se pude dividir por 0");
        } 
        else
        {
            dato /= termino;
        }
    }
    public void Limpiar()
    {
        dato = 0;
    }
    public double Resultado => dato;
    
}