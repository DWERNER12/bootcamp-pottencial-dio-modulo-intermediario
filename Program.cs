
using ExemploExplorando.Models;
using System.Globalization;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

Console.WriteLine(estados["MG"]);

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


Console.WriteLine("---------");

estados.Remove("BA");
estados["SP"] = "São Paulo - foi alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Não existe. É possivel adicionar a chave: {chave}");
}








/*
exemplo de pilha

Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
*/


/*
exemplo de fila

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}
*/


















/*
lendo arquivo 
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}


simulando exceção
try 
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}
*/
















/*
trabalhando com datas
string data3 = "1995/05/12 14:00";
DateTime data = DateTime.Now;
DateTime data2 = DateTime.Parse("02/06/2022 10:00");

Console.WriteLine($"{data:dd/MM/yyyy HH:mm}");
Console.WriteLine($"{data.ToShortTimeString()}");
Console.WriteLine($"{data2}");
Console.WriteLine($"{DateTime.Parse(data3)}");
DateTime.TryParseExact(data3, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataExact);
Console.WriteLine(dataExact);
*/








/*
altera a cultura global do programa
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 82.40M;

Console.WriteLine($" {valorMonetario:C2}");

double porc = .3452;

Console.WriteLine($"{porc:p}");

int numero = 123456;
Console.WriteLine($"{numero:##-##-##}");

altera a cutura dirwto na saida
Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("pt-BR")));
*/













/*
//usando contrutor podemos passar os valores do parametro direto no new
Pessoa p1 = new Pessoa(nome: "David", sobrenome: "Werner");
fazendo p set das propriedades 
p1.Nome = "David";
p1.Sobrenome = "Werner";
p1.Idade = 27;

Pessoa p2 = new Pessoa();
p2.Nome = "Mel";
p2.Sobrenome = "Werner";
//p1.Idade = 5;

Curso cursoDeProgramacao = new Curso();
cursoDeProgramacao.Nome = "Programação";
cursoDeProgramacao.Alunos = new List<Pessoa>();

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos();*/

