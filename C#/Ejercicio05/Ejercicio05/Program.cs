Console.Write("Depósito inicial: S/");
double saldo = double.Parse(Console.ReadLine());

Console.Write("Meta a alcanzar: S/");
double meta = double.Parse(Console.ReadLine());

double tasa = 0.015; // 1.5% mensual
int meses = 0;

Console.WriteLine($"Mes 0: S/{saldo:F2}");

// El bucle se ejecuta mientras no hayamos llegado a la meta
while (saldo < meta)
{
    saldo = saldo * (1 + tasa);
    meses = meses + 1;

    Console.WriteLine($"Mes {meses}: S/{saldo:F2}");
}

Console.WriteLine($"Alcanzará la meta en {meses} meses.");
