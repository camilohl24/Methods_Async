Console.WriteLine("Diagnosticando uno por uno:");
string r1 = await DiagnoseSparePartAsync("Motor...");
string r2 = await DiagnoseSparePartAsync("Frenos...");
string r3 = await DiagnoseSparePartAsync("Suspensión...");

Console.WriteLine("\n Resultados Obtenidos:");
Console.WriteLine($"- {r1}: Ok");
Console.WriteLine($"- {r2}: Ok");
Console.WriteLine($"- {r3}: Ok");

Console.WriteLine("\nDiagnostico Simultaneo:");
Task<string> t1 = DiagnoseSparePartAsync("Trasmision...");
Task<string> t2 = DiagnoseSparePartAsync("Dirección...");
Task<string> t3 = DiagnoseSparePartAsync("Sistema Electrico...");

string[] results = await Task.WhenAll(t1, t2, t3);
foreach (string result in results)
{
    Console.WriteLine($"- {result}: Ok");
}
static async Task<string> DiagnoseSparePartAsync(string sparePart)
{
    Console.WriteLine($"Diagnosticando: {sparePart}");
    await Task.Delay(1500); 
    return sparePart;
}
