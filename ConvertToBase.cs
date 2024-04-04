
string ConvertToBase(int x, int k)
{
    if (k <= 1)
    {
        throw new ArgumentException("La base debe ser mayor que 1.");
    }

    string result = "";

    while (x > 0)
    {
        int remainder = x % k;
        x /= k;
        result = remainder.ToString() + result;
    }

    return (result == "") ? "0" : result;
}


Console.Write("Ingrese el número a convertir: ");
Console.Write("Ingrese la base: ");

try
{
    int x = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    string result = ConvertToBase(x, k);
    Console.WriteLine($"El resultado es {result}");
}
catch (FormatException)
{
    Console.WriteLine("El valor ingresado no es un número válido");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
