/* Faça um programa que leia 10 numero inteiros e faça os seguintes itens:
	a) imprima o vetor lido
	b) imprima o vetor de trás pra frente
	c) imprima até a metade do vetor
	d) guarde e imprima os valores ímpares em um novo vetor (sem os valores 0)
	e) guarde e imprima os valores pares em um novo vetor (sem os valores 0)
*/

int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];
int contPares = 0, contImpares = 0;
int option;

do
{
    Console.WriteLine("Digite 10 valores:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        numeros[i] = int.Parse(Console.ReadLine());

        if (numeros[i] % 2 == 0)
        {
            pares[contPares] = numeros[i];
            contPares++;
        }
        else
        {
            impares[contImpares] = numeros[i];
            contImpares++;
        }
    }

    Console.WriteLine("\nVetor lido:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\nVetor invertido:");
    for (int i = 9; i >= 0; i--)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\nMetade do vetor:");
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{numeros[i]} ");
    }

    Console.WriteLine("\nValores pares:");
    for (int i = 0; i < contPares; i++)
    {
        Console.Write($"{pares[i]} ");
    }

    Console.WriteLine("\nValores impares:");
    for (int i = 0; i < contImpares; i++)
    {
        Console.Write($"{impares[i]} ");
    }

    do
    {
        Console.WriteLine("\n\nDeseja sair do programa?");
        Console.WriteLine("1 - Sair");
        Console.WriteLine("2 - Continuar");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);