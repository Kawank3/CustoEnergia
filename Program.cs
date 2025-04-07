Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("--- Custo de Energia ---");
Console.ResetColor();

Console.WriteLine("Consumo do aparelho (em kWh/mês)...: 17,1");
Console.WriteLine("Custo do aparelho (em R$).........: 0,62258");
Console.Write("Informe horas de uso por dia: ");
string? input = Console.ReadLine();

decimal Horas = Convert.ToDecimal(input);
decimal Custo = Horas * 17.1m * 0.62258m;

Console.WriteLine("Custo Estimado Mensal: R$ ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{Custo:F2}");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("NeoEnergia, B1-Residencial, Consumo Ativo, sem considerar bandeira tarifária e impostos.");
Console.ResetColor();