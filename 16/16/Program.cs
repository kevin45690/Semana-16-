using System; // Importa el espacio de nombres necesario para la entrada y salida de datos

class program // Define la clase principal del programa
{
    static void Main(string[] args) // Método principal donde inicia la ejecución del programa
    {
        // Solicitar el nombre del estudiante
        Console.Write("^^Ingrese el nombre del estudiante: ^^");
        string nombre = Console.ReadLine();

        // Validar que el nombre no esté vacío
        while (string.IsNullOrWhiteSpace(nombre)) // Comprueba si el nombre es nulo, vacío o solo contiene espacios
        {
            Console.Write("El nombre no puede estar vacio. Ingrese el nombre por favor: ");
            nombre = Console.ReadLine();
        }

        // Solicitar la calificación
        Console.Write("°°°°°°°°°°°°°°°INGRESE LA CALIFICACION DEL ESTUDIANTE (0-10)°°°°°°°°°°°°°°:");
        string inputCalifacion = Console.ReadLine();
        double calificacion;

        // Validar que la calificación sea un número válido dentro del rango de 0 a 10
        while (!double.TryParse(inputCalifacion, out calificacion) || calificacion < 0 || calificacion > 10)
        {
            Console.Write("Calificación inválida. Ingresar una calificación entre 0 y 10: ");
            inputCalifacion = Console.ReadLine();
        }

        // Determinar si el estudiante ha aprobado o reprobado
        if (calificacion >= 6) // Si la calificación es 6 o mayor, el estudiante aprueba
        {
            Console.WriteLine($"¡Felicidades, {nombre}! Has aprobado con una calificación de {calificacion}.");
        }
        else // Si la calificación es menor a 6, el estudiante reprueba
        {
            Console.WriteLine($"Lo sentimos mucho, {nombre}. Has reprobado con una calificación de {calificacion}.");
        }
    }
}