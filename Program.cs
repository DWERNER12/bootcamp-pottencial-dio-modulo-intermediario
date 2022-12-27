
using ExemploExplorando.Models;


//usando contrutor podemos passar os valores do parametro direto no new
Pessoa p1 = new Pessoa(nome: "David", sobrenome: "Werner");
/*fazendo p set das propriedades 
p1.Nome = "David";
p1.Sobrenome = "Werner";
p1.Idade = 27;*/

Pessoa p2 = new Pessoa();
p2.Nome = "Mel";
p2.Sobrenome = "Werner";
//p1.Idade = 5;

Curso cursoDeProgramacao = new Curso();
cursoDeProgramacao.Nome = "Programação";
cursoDeProgramacao.Alunos = new List<Pessoa>();

cursoDeProgramacao.AdicionarAluno(p1);
cursoDeProgramacao.AdicionarAluno(p2);
cursoDeProgramacao.ListarAlunos();

