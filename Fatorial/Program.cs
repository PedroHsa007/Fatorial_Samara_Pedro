using System;
using Fatorial;


//variaveis. "Num" armazena.
Console.WriteLine("Digite um número para calcular o fatorial: ");
int num = int.Parse(Console.ReadLine());

int resultado = Fatorar.Calcular(num);
Console.WriteLine($"O Fatorial de {num} é {resultado}.");