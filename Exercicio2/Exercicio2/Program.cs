using Exercicio2;


Capivara capivara1 = new Capivara
{
    Nome = "Capivárias",
    Especie = "Caviidae",
};
capivara1.EmitirSom();
Console.WriteLine($"Nome: {capivara1.Nome}");
Console.WriteLine($"Espécie: {capivara1.Especie}");

//***********************************************************************
Gato gato1 = new Gato
{
    Nome = "Gatito",
    Especie = "Maine Coon",
};
gato1.EmitirSom();
Console.WriteLine($"Nome: {gato1.Nome}");
Console.WriteLine($"Espécie: {gato1.Especie}");

//**********************************************************************
Porco porco1 = new Porco
{
    Nome = "Porcorias",
    Especie = "Babirussa",
};
porco1.EmitirSom();
Console.WriteLine($"Nome: {porco1.Nome}");
Console.WriteLine($"Espécie: {porco1.Especie}");


Console.ReadKey();