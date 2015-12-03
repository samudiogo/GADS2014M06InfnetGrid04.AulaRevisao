using System;

namespace GADS2014M06InfnetGrid04.AulaRevisao.Domain.Entidades
{
    public abstract class Pessoa
    {
        public DateTime DataNascimento { get; set; }


        //virtual quando eu tenho uma implementação generica do método
        // ou quando estou escrevendo um método que pode ser sobrescrito pela classe filha
        public virtual void Fala()
        {
            Console.WriteLine("fala generica");
        }

        public abstract void Anda();
    }
}