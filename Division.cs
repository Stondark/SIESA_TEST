// Realice un algoritmo que reciba como parámetro dos números enteros y retorne la
// división de ambos números.

double division(double x, double y)
{
    if (y == 0)
    {
        // return 0; Returnamos 0 o una excepción
        throw new Exception("La división entre 0 no está permitida");
    }

    return x / y;
};

Console.WriteLine("Ingrese un valor para x: ");
string inputX = Console.ReadLine();
Console.WriteLine("Ingrese un valor para y: ");
string inputY = Console.ReadLine();
try
{

    double x = double.Parse(inputX);
    double y = double.Parse(inputY);
    Console.WriteLine(division(x, y));
}
catch(FormatException) {
    Console.WriteLine("El valor ingresado no es un número válido");
}catch (Exception ex) 
{
    Console.WriteLine(ex.Message); 
}
