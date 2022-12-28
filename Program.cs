
using ExemploExplorando.Models;
using System.Globalization;















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

