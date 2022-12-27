using exemplo_fundamentos.models;

Pessoa pessoa1 = new Pessoa();
DateTime HoraAtual= DateTime.Now;

pessoa1.Nome = "Viktor";
pessoa1.Idade = 25;
pessoa1.Apresentar();
Console.WriteLine(HoraAtual);