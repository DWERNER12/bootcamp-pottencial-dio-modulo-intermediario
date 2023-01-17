using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(int id, string nome, string sobrenome)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // public void Deconstruct(out string nome, out string sobrenome)
        // {
        //     nome = Nome;
        //     sobrenome = Sobrenome;
        // }
        private string _nome;
        private int _idade;
        public int Id { get; set; }
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                //se paramtro vazio 
                if(value == "")
                {
                    //para o programa usando exceção
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        {
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new AggregateException("A idade não pode ser menor que zero.");
                }

                _idade = value;
            }   
        }

        public void Apresentar()
        {
            //fazendo o get das propriedades
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}