public class Program
{
    private static void Main(string[] args)
    {
        // Leer los valores de entrada
        Console.Write("Introduce el primer valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo valor: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        // Validar y calcular la división
        if (valor1 == valor2)
        {
            Console.WriteLine("Los valores son iguales, no se puede determinar la división.");
        }
        else
        {
            // Determinar el mayor y el menor
            double mayor = Math.Max(valor1, valor2);
            double menor = Math.Min(valor1, valor2);

            // Validar que el menor no sea cero para evitar indeterminación
            if (menor == 0)
            {
                Console.WriteLine("La división no está definida porque el menor valor es cero.");
            }
            else
            {
                // Realizar la división
                double resultado = mayor / menor;
                Console.WriteLine("La división del mayor entre el menor es: " + resultado);
            }
        }
    }
}


