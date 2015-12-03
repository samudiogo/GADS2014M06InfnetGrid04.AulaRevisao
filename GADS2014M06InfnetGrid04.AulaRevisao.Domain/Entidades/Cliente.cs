using System;
using System.Collections.Generic;

namespace GADS2014M06InfnetGrid04.AulaRevisao.Domain.Entidades
{
    public class Cliente: Pessoa
    {
        #region Propriedades
        public Guid Codigo { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Endereco { get; set; }

        //Lista de telefone do cliente
        public List<Telefone> Telefones { get; set; } 
        #endregion

        public Cliente()
        {
            Codigo = new Guid();
        }

        public override void Anda()
        {
            Console.WriteLine("cliente andando");
        }


        public override void Fala()
        {
            base.Fala();
            Console.WriteLine("CLiente falando");
        }
    }
}
