double saldo = 1000.00;
int retiros = 0;

Console.WriteLine("=== CAJERO AUTOMÁTICO ===");
Console.WriteLine($"Saldo disponible: S/{saldo:F2}");

Console.Write("Monto a retirar (0 para salir): ");
double monto = double.Parse(Console.ReadLine());

// El bucle continúa mientras el monto sea diferente de 0
while (monto > 0)
{
    if (monto < 0)
    {
        Console.WriteLine("Error: monto inválido.");
    }
    else if (monto > saldo)
    {
        Console.WriteLine("Error: saldo insuficiente.");
    }
    else
    {
        // Restamos el monto al saldo y aumentamos el contador de retiros
        saldo = saldo - monto;
        retiros = retiros + 1;

        Console.WriteLine($"Retiro exitoso. Saldo: S/{saldo:F2}");
    }

    Console.Write("Monto a retirar (0 para salir): ");
    monto = double.Parse(Console.ReadLine());
}

Console.WriteLine("--- RESUMEN ---");
Console.WriteLine($"Retiros realizados: {retiros}");
Console.WriteLine($"Saldo restante: S/{saldo:F2}");
