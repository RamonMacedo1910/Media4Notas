double Nota1B, Nota2B, Nota3B, Nota4B, Media;
string resultado;




Console.WriteLine("---Media de notas---\n");

Console.WriteLine("digite as suas notas abaixo:\n");

Console.WriteLine("por favor, digite sua nota do 1°bimestre; ");
Nota1B = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("por favor, digite sua nota do 2°bimestre; ");
Nota2B = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("por favor, digite sua nota do 3°bimestre; ");
Nota3B =  Convert.ToDouble(Console.ReadLine());


Console.WriteLine("por favor, digite sua nota do 4°bimestre; ");
Nota4B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

if (Nota1B < 0 || Nota1B > 10
||  Nota2B < 0 || Nota2B > 10 
||  Nota3B < 0 || Nota3B > 10
||  Nota4B < 0 || Nota4B > 10 
)

{
    Console.WriteLine("Por favor, digite apenas de 0 à 10");

}

else
{
    Media = (Nota1B + Nota2B + Nota3B + Nota4B) /4;

        if (Media < 6)
        {
            resultado = "reprovado";
        }

        else if (Media > 7)
        {
            resultado = "aprovado";
        }

        else 
        {
            resultado = "está em recuperação";

        }

        Console.WriteLine($"sua Média foi de: {Media:N1}\ne seu resultado: {resultado}! ");
}













