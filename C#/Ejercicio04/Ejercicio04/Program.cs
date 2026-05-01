Random rand = new Random();

int secreto = rand.Next(1, 51); // Numero entre 1 y 50

int intentos = 0;
int maxIntentos = 7;
bool adivino = false;

Console.WriteLine("Adivina el numero entre 1 y 50. Tienes 7 intentos.");

// El while continua mientras queden intentos y todavia no haya adivinado
while (intentos < maxIntentos && adivino == false)
{
    intentos++;

    Console.Write($"Intento {intentos}: ");
    int intento = int.Parse(Console.ReadLine());

    if (intento == secreto)
    {
        adivino = true;
    }
    else if (intento < secreto)
    {
        Console.WriteLine("El numero secreto  es MAYOR.");
    }
    else
    {
        Console.WriteLine("El numero es MENOR.");
    }
}

// Al salir del while, se revisa si gano o perdio
if (adivino == true)
{
    Console.WriteLine($"Ganaste en {intentos} intentos.");
}
else
{
    Console.WriteLine($"Perdiste. El nuero era {secreto}.");
}