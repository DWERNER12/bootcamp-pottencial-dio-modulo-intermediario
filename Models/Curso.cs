using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
            string serializado = JsonConvert.SerializeObject(Alunos, Formatting.Indented);

            File.WriteAllText("Arquivos/Alunos.json", serializado);
            Console.WriteLine(serializado);
            //Console.WriteLine(Alunos.Count);
        }
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do Curso: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; Concatenado
                Console.WriteLine($"Nº {count + 1} - {Alunos[count].NomeCompleto}");
            }

        }
    }
}