Console.WriteLine("Obteniendo repuestos para el mantenimiento del vehículo...");

string part1 = await GetSparePartAsync("Aceite");
string part2 = await GetSparePartAsync("Filtro de aire");
string part3 = await GetSparePartAsync("Bujías");

Console.WriteLine("Repuestos obtenidos para el mantenimiento del vehículo:");
Console.WriteLine($"- {part1}");
Console.WriteLine($"- {part2}");
Console.WriteLine($"- {part3}");



static async Task<string> GetSparePartAsync(string part)
    {
        Console.WriteLine($"Obteniendo:\t {part,14}");
        await Task.Delay(2000); // Simula el tiempo de obtención del repuesto  
        return part;
    }
