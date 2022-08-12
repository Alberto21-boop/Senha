using System;

namespace Senha;

public class Program
{
    static void Main(string[] args)
    {
        int A, B;

        Console.WriteLine("Vamos cadastrar uma senha agora");
        Console.Write("Digite uma senha apenas com numeros por favor: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Agora para acessar, digite sua senha");
        B = int.Parse(Console.ReadLine());

        while(A != B)
        {
            Console.WriteLine("ACESSO NEGADO! DIGITE NOVAMENTE A SENHA");
            B = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("ACESSO PERMITIDO");
        Console.WriteLine("Seja bem vindo");

    }
}