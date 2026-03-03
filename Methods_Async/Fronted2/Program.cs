Console.WriteLine("\nObteniendo repuestos para el mantenimiento del vehículo de forma concurrente...");


string r1 = await GetSparePartAsync("Cigueñal");
string r2 = await GetSparePartAsync("Bomba de agua");
string r3 = await GetSparePartAsync("Correa de distribución");

Task<string> t1 = GetSparePartAsync("Cigueñal");
Task<string> t2 = GetSparePartAsync("Bomba de agua");
Task<string> t3 = GetSparePartAsync("Correa de distribución");

string[] parts = await Task.WhenAll(t1, t2, t3);
foreach (string part in parts)

{
    Console.WriteLine($"- {part}");
}

static async Task<string> GetSparePartAsync(string part)
{ 
    await Task.Delay(5000); 
    return part;
}
