/*
2. Faça um vetor de caracteres de 10 posições e imprima os seguintes itens:
	a. somente as vogais;
	b. somente as consoantes;
*/

int tamanho = 10;
char[] palavra = new char[tamanho];
char[] vogais = new char[5] { 'a', 'e', 'i', 'o', 'u' };
char[] consoante = new char[21] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
char[] alfabeto = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char letra;

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Digite a {i + 1}ª letra:");
    palavra[i] = char.Parse(Console.ReadLine());

}

Console.WriteLine("Vogais:");
for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (palavra[i] == vogais[j])
        {
            Console.WriteLine(palavra[i]);
        }
    }
}

Console.WriteLine("Consoantes:");
for (int i = 0; i < tamanho; i++)
{
    for (int j = 0; j < 21; j++)
    {
        if (palavra[i] == consoante[j])
        {
            Console.WriteLine(palavra[i]);
        }
    }
}