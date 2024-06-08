int numero = 15;
bool ehPar = false;

//If ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));

if (numero % 2 == 0)
{
    Console.WriteLine($"O numero {numero} é par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}
