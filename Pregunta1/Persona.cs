using System;

public abstract class Persona
{
    
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Identificacion { get; set; }


    public Persona(string nombre, int edad, string identificacion)
    {
        Nombre = nombre;
        Edad = edad;
        Identificacion = identificacion;
    }

    public abstract void MostrarInformacion();
}