using System;

public class Program
{
    public static void Main()
    {
        
        Estudiante estudiante = new Estudiante("Pepe Mujica", 19, "tre2123", "Sociales", 3);
        Administrativo administrativo = new Administrativo("Amber Heard", 32, "rert1232", "Recursos Humanos", "Coordinadora");
        Docente docente = new Docente("Jose Pardo", 50, "fsc123", "Fisica", 20);

        
        estudiante.MostrarInformacion();
        administrativo.MostrarInformacion();
        docente.MostrarInformacion();
    }
}