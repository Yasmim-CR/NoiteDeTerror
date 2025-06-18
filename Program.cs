Console.Clear();

string[] monstrosMes = [
            "", "O Zumbi", "O Assassino", "O Psicopata", "O Alienígena",
            "O Carniceiro", "O Matador", "O Vampiro", "O Maluco",
            "O Vingador", "O Monstro", "O Bruxo", "O Demônio"
        ];

string[] sobrenomesDia = [
            "", "Endiabrado", "Radioativo", "Endemoniado", "Vermelho", "Possuído", "Macabro",
            "Sombrio", "Sem Cabeça", "Desconhecido", "Inconsciente", "Oculto", "Esquecido",
            "Lúgubre", "Invocado", "Caído", "Costurado", "Amaldiçoado", "Anormal",
            "Perturbado", "Sanguinário", "Tenebroso", "Imortal", "Ressuscitado", "do Pântano",
            "da Encruzilhada", "do Porão", "do Velho Poço", "sem Perdão", "do Cemitério",
            "da Meia-Noite", "da Lua Cheia"
        ];



Console.WriteLine("\n-- Noite de Terror ---\n");

Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");
int dia = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");
int mes = Convert.ToInt32(Console.ReadLine()!);

if (dia < 1 && dia > 31 && mes < 1 && mes > 12)
{
    Console.WriteLine("Digite uma data válida");
}
else
{
    Console.WriteLine($"Fuja! Lá vem {monstrosMes[mes]} {sobrenomesDia[dia]}!");
}