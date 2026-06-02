using ToDo;


Console.WriteLine("Introduzca el numero de tareas");
int numTareas = Convert.ToInt32(Console.ReadLine());
List<Tarea> tareaspendientes = new List<Tarea>();
List<Tarea> tareasrealizadas = new List<Tarea>();
for (int i = 0; i < numTareas; i++)
{
    int id = Convert.ToInt32(i + 1);
    Console.WriteLine("Introduzca la descripcion de la tarea");
    string? descripcion = Console.ReadLine();
    int duracion = Convert.ToInt32(Random.Shared.Next(10, 100));
    Tarea tarea = new Tarea(id, descripcion, duracion);
    tareaspendientes.Add(tarea);
}

int Continuar = 1;
while (Continuar == 1)
{
    Console.WriteLine("Introduzca la descripcion de la tarea completada");
    string? descripcionTarea = Console.ReadLine();
    if (tareaspendientes.Any(t => t.Descripcion == descripcionTarea))
    {
        Tarea tarea = tareaspendientes.First(t => t.Descripcion == descripcionTarea);
        if (tarea != null)
        {
            Console.WriteLine($"Tarea encontrada: {tarea.Descripcion} - Duracion: {tarea.Duracion} minutos");
            Console.WriteLine("¿Desea marcar esta tarea como completada? (1 para si, 0 para no)");
            int marcarCompletada = Convert.ToInt32(Console.ReadLine());
            if (marcarCompletada == 1)
            {
                tareaspendientes.Remove(tarea);
                tareasrealizadas.Add(tarea);
                Console.WriteLine("Tarea completada");
            }
            else
            {
                Console.WriteLine("Tarea no marcada como completada");
            }
        }

    }
    else
    {
        Console.WriteLine("Tarea no encontrada");
    }
    Console.WriteLine("¿Desea continuar? (1 para continuar, 0 para salir)");
    Continuar = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Tareas realizadas:");
foreach (Tarea tarea in tareasrealizadas)
{
    Console.WriteLine($"Tarea {tarea.TareaId}: {tarea.Descripcion} - Duracion: {tarea.Duracion} minutos");
}
Console.WriteLine("Tareas pendientes:");
foreach (Tarea tarea in tareaspendientes)
{
    Console.WriteLine($"Tarea {tarea.TareaId}: {tarea.Descripcion} - Duracion: {tarea.Duracion} minutos");
}