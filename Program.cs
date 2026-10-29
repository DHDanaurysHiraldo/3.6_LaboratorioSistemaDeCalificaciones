
   

Console.WriteLine("============================================");
Console.WriteLine("=== Sistema de Calificaciones Académicas ===");
Console.WriteLine("============================================");

Console.Write("Nombre del estudiante: ");
string nombre = Console.ReadLine();

Console.Write("Calificación (0-100): ");
if (!decimal.TryParse(Console.ReadLine(), out decimal calificacion))
{
    Console.WriteLine("Error: entrada no numérica. No se calcula resultado.");
}
else
{
    if (calificacion < 0 || calificacion > 100)
    {
        Console.WriteLine("Error: nota fuera de rango (0-100).");
    }
    else
    {
        string clasificacion;
        if (calificacion >= 90)

            clasificacion = "Excelente";

        else if (calificacion >= 80)
        {
            clasificacion = "Muy Bueno";
        }
        else if (calificacion >= 70)
        {
            clasificacion = "Aprobado";
        }
        else
        {
            clasificacion = "Reprobado";
        }

        string condicion;
        if (calificacion >= 70)
        {
            condicion = "Aprobado";
        }
        else
        {
            condicion = "Reprobado";
        }

        Console.Clear();
        Console.WriteLine("============================================");
        Console.WriteLine("=== Sistema de Calificaciones Académicas ===");
        Console.WriteLine("============================================");
        Console.WriteLine();
        Console.WriteLine("=== RESUMEN ACADÉMICO ===");
        Console.WriteLine($"Estudiante: {nombre}");
        Console.WriteLine($"Nota: {calificacion}");
        Console.WriteLine($"Clasificación: {clasificacion}");
        Console.WriteLine($"Condición Académica: {condicion}");
    }
    
}
    



