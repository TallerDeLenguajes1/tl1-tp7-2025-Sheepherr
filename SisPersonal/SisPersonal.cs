namespace EspacioSisPersonal;

public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
public class Empleado
{
    public string Nombre
    {
        get;
        set;
    }
    public string Apellido
    {
        get;
        set;
    }
    public DateTime FechN
    {
        get;
        set;
    }
    public  char EstadoCivil
    {
        get;
        set;
    }
    public DateTime FechIng
    {
        get;
        set;
    }

    public decimal Sueldo
    {
        get;
        private set;
    }
    public Cargo CargoEmpleado {get; set;}

    public int Antiguedad 
    {
       get 
       {    
        int antiguedad = DateTime.Now.Year - FechIng.Year;
        return antiguedad;
       }
    }    
    public int Edad 
    {
        get 
        {   
            int edad = DateTime.Now.Year - FechN.Year;
            if (DateTime.Now.DayOfYear < FechN.DayOfYear)
            {
                edad--;
            }
            return edad;
        }
    }
    public int Jubil 
    {
        get
        {
            int jubil = 65 - Edad; 
            if (jubil > 0)
            {
                return jubil;
            }
            else
            {
                return 0;
            }
        }
    }

    public void CalcularSueldo (decimal sldoB)
    {
        decimal adicional = 0;
        if (Antiguedad > 20 || Antiguedad == 0)
        {
            adicional = sldoB * (Antiguedad / 100m);
            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
            {
                adicional += (adicional * 0.5m);
            }
            if (EstadoCivil == 'c')
            {
                adicional += 150000m;
            }
        }
        else
        {
            adicional = sldoB * (25 / 100m);
            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
            {
                adicional += (adicional * 0.5m);
            }
            if (EstadoCivil == 'c')
            {
                adicional += 150000m;
            }
        }
        Sueldo = sldoB + adicional;
    }
    
}