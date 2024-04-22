char[] palavra = new char[10];

for (int i = 0; i < 10; i++)
{
    palavra[i] = char.Parse(Console.ReadLine());
}

Console.WriteLine("Vogais");
for (int i = 0; i < 10; i++)
{
    if (palavra[i] == 'a' || palavra[i] == 'e' || palavra[i] == 'i' || palavra[i] == 'o' || palavra[i] == 'u')
    {
        Console.Write(palavra[i]);
    }
}
Console.WriteLine();

Console.WriteLine("Consoantes");
for (int i = 0; i < 10; i++)
{
        if (palavra[i] != 'a' && palavra[i] != 'e' && palavra[i] != 'i' && palavra[i] != 'o' && palavra[i] != 'u')
        {
            Console.Write(palavra[i]);
        }
}