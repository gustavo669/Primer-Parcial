class Program1
{
    static void Main(string[] args)
    {
        int numero;

        do
        {
            Console.WriteLine("Ingrese un número entero positivo (o ingrese 0 para salir):");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out numero))
            {
                Console.WriteLine("Debe ingresar un número entero válido.");
                continue;
            }

            if (numero < 0)
            {
                Console.WriteLine("Debe ingresar un número entero positivo.");
                continue;
            }

            if (numero == 0)
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            MostrarMenu(numero);
        } while (true);
    }

    static void MostrarMenu(int numero)
    {
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Calcular el factorial del número.");
            Console.WriteLine("2. Calcular la raíz cuadrada del número.");
            Console.WriteLine("3. Salir del programa.");
            Console.WriteLine("Elija una opción:");

            string opcionStr = Console.ReadLine();

            if (!int.TryParse(opcionStr, out int opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción inválida. Por favor, elija una opción del menú (1, 2 o 3).");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    CalcularFactorial(numero);
                    break;
                case 2:
                    CalcularRaizCuadrada(numero);
                    break;
                case 3:
                    Console.WriteLine("Saliendo del menú...");
                    return;
            }
        }
    }

    static void CalcularFactorial(int numero)
    {
        long factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static void CalcularRaizCuadrada(int numero)
    {
        double raizCuadrada = Math.Sqrt(numero);
        Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");
    }
}
class Program2
{
    static void Main(string[] args)
    {
        int num1, num2;
        char operador;

        Console.WriteLine("Ingrese el primer número entero:");
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero:");
        }

        Console.WriteLine("Ingrese el segundo número entero:");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero:");
        }

        Console.WriteLine("Ingrese el operador matemático (+, -, *, /):");
        while (!char.TryParse(Console.ReadLine(), out operador) || !EsOperadorValido(operador))
        {
            Console.WriteLine("Operador inválido. Por favor, ingrese un operador matemático válido (+, -, *, /):");
        }

        double resultado = RealizarOperacion(num1, num2, operador);
        Console.WriteLine($"El resultado de la operación {num1} {operador} {num2} es: {resultado}");
    }

    static bool EsOperadorValido(char operador)
    {
        return operador == '+' || operador == '-' || operador == '*' || operador == '/';
    }

    static double RealizarOperacion(int num1, int num2, char operador)
    {
        switch (operador)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                if (num2 != 0)
                    return (double)num1 / num2;
                else
                    throw new ArgumentException("No se puede dividir por cero.");
            default:
                throw new ArgumentException("Operador no válido.");
        }
    }
}
class Program3
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un número para generar la tabla de multiplicar:");
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero:");
        }

        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
class Program4
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("¡Bienvenido al juego de adivinar el número secreto!");
        Console.WriteLine("El número secreto está entre 1 y 100. ¡Adivina cuál es!");

        do
        {
            Console.WriteLine("Ingresa tu intento:");
            while (!int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero:");
            }

            intentos++;

            if (intentoUsuario == numeroSecreto)
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el número secreto {numeroSecreto} en {intentos} intentos.");
                break;
            }
            else if (intentoUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor. ¡Sigue intentándolo!");
            }
            else
            {
                Console.WriteLine("El número secreto es menor. ¡Sigue intentándolo!");
            }
        } while (true);
    }
}