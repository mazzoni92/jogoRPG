

int jogador = 100;
int inimigo = 100;
int fortalecimento = 3;

Console.WriteLine("Bem vindo");
Console.WriteLine("Isso é um RPG basico de comandos");
Console.WriteLine("  ");
Console.WriteLine("Digite o nome do personagem: ");
string nomeJogador = Console.ReadLine();
Console.WriteLine($"{nomeJogador} bora para aventura");
while(inimigo > 0 && jogador > 0)
{
    Console.WriteLine("1 - Atacar ");
    Console.WriteLine("2 - Defender ");
    Console.WriteLine("3 - Desviar ");
    Console.WriteLine("4 - fortalecimento ");
    int escolha = int.Parse(Console.ReadLine());
    if (escolha == 1)
    {
        Console.WriteLine("Voce atacou o inimigo");
        Random random = new Random();
        int ataque = random.Next(1, 10);
        inimigo = inimigo - ataque;
        Console.WriteLine($"Seu ataque foi de {ataque}");
        Console.WriteLine($"Vida do inimigo: {inimigo}");
        Console.WriteLine("Inimigo atacou");
        int ataqueInimigo = random.Next(1, 10);
        jogador = jogador - ataqueInimigo;
        Console.WriteLine($"Ataque inimigo foi {ataqueInimigo}");
        Console.WriteLine($"Vida de {nomeJogador}:{jogador}");
    }
    else if (escolha == 2)
    {
        Random random = new Random();
        int ataqueInimigo = random.Next(1, 10);
        Console.WriteLine($"Ataque inimigo foi {ataqueInimigo}");
        Console.WriteLine("Voce defendeu o ataque do inimigo");
    }
    else if (escolha == 3)
    {
        Console.WriteLine("Voce desviou do ataque do inimigo");
    }
    else if (escolha == 4)
    {
        while (fortalecimento > 0)
        {
            fortalecimento = fortalecimento - 1;
            Random random = new Random();
            int ataque = random.Next(10, 20);
            inimigo = inimigo - ataque;
            Console.WriteLine("Voce deu um super ataque");
            Console.WriteLine($"Seu ataque foi {ataque}");
            int ataqueInimigo = random.Next(1, 10);
            jogador = jogador - ataqueInimigo;
        }
    }
    else
    {
        Console.WriteLine("Voce escolheu comando errado, favor realizar novo comando: ");
        escolha = int.Parse( Console.ReadLine() );
    }
}