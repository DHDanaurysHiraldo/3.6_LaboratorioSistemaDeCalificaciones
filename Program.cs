

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
else if (calificacion < 0 || calificacion > 100)
{
    Console.WriteLine("Error: nota fuera de rango (0-100).");
}
else
{
    Console.WriteLine($"Nota válida: {calificacion}");   // temporal
}


