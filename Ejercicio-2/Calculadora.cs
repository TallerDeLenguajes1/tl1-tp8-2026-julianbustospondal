namespace CalculadoraEspacio;

public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar  // Representa la acción de borrar el resultado actual o el historial 
}

public class Operacion
{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior 
    public TipoOperacion operacion;// El tipo de operación realizada 
    public double Resultado
    {
        get { return resultadoAnterior; }
        set { resultadoAnterior = value; }
    }
    // Propiedad pública para acceder al nuevo valor utilizado en la operación 
    public double NuevoValor
    {
        get { return nuevoValor; }
        set { nuevoValor = value; }
    }
    // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
    // ... 
}
class Calculadora
{
    double numero1;
    double numero2;
    public double GetNumero1()
    {
        return numero1;
    }
    public double GetNumero2()
    {
        return numero2;
    }
    public void SetNumero1(double numero1)
    {
        this.numero1 = numero1;
    }
    public void SetNumero2(double numero2)
    {
        this.numero2 = numero2;
    }
    public double Sumar(double numero1, double numero2)
    {
        double resultado = numero1 + numero2;
        Operacion operacion = new Operacion
        {
            Resultado = resultado,
            NuevoValor = numero2,
            operacion = TipoOperacion.Suma
        };
        return resultado;

    }
    public double Restar(double numero1, double numero2)
    {
        double resultado = numero1 - numero2;
        Operacion operacion = new Operacion
        {
            Resultado = resultado,
            NuevoValor = numero2,
            operacion = TipoOperacion.Resta
        };
        return resultado;
    }
    public double Multiplicar(double numero1, double numero2)
    {
        double resultado = numero1 * numero2;
        Operacion operacion = new Operacion
        {
            Resultado = resultado,
            NuevoValor = numero2,
            operacion = TipoOperacion.Multiplicacion
        };
        return resultado;
    }
    public double Dividir(double numero1, double numero2)
    {
        double resultado = numero1 / numero2;
        Operacion operacion = new Operacion
        {
            Resultado = resultado,
            NuevoValor = numero2,
            operacion = TipoOperacion.Division
        };
        return resultado;
    }
    public void Limpiar() { }
}
