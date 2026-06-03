using CalculadoraEspacio;

int continuar = 1;
double resultado = 0;
double numero1 = 0;
List<Operacion> historialOperaciones = new List<Operacion>();
while (continuar == 1)
{
    if (numero1 != 0)
    {
        Console.WriteLine("Usar resultado anterior como primer número? (1:si/0:no) ");
        int usarResultadoAnterior = Convert.ToInt32(Console.ReadLine());
        if (usarResultadoAnterior == 1 && historialOperaciones.Count > 0)
        {
            numero1 = historialOperaciones.Last().Resultado;
        }
        else
        {
            Console.WriteLine("Ingrese el primer número:");
            numero1 = Convert.ToDouble(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Ingrese el primer número:");
        numero1 = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Ingrese el segundo número:");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    Calculadora calculadora = new Calculadora();
    calculadora.SetNumero1(numero1);
    calculadora.SetNumero2(numero2);

    Console.WriteLine("Seleccione la operación a realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            resultado = calculadora.Sumar(calculadora.GetNumero1(), calculadora.GetNumero2());
            break;
        case 2:
            resultado = calculadora.Restar(calculadora.GetNumero1(), calculadora.GetNumero2());
            break;
        case 3:
            resultado = calculadora.Multiplicar(calculadora.GetNumero1(), calculadora.GetNumero2());
            break;
        case 4:
            resultado = calculadora.Dividir(calculadora.GetNumero1(), calculadora.GetNumero2());
            break;
        default:
            Console.WriteLine("Opción no válida.");
            continue;
    }

    Console.WriteLine($"El resultado es: {resultado}");
    Console.WriteLine("¿Desea realizar otra operación? (1:si/0:no)");
    continuar = Convert.ToInt32(Console.ReadLine());
    historialOperaciones.Add(new Operacion
    {
        Resultado = resultado,
        NuevoValor = numero2,
        operacion = (TipoOperacion)(opcion - 1)
    });
}
foreach (var operacion in historialOperaciones)
{
    Console.WriteLine($"Operación: {operacion.operacion},  Nuevo Valor: {operacion.NuevoValor}, Resultado: {operacion.Resultado}");
}


