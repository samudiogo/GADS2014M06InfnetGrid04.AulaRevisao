using System;

namespace GADS2014M06InfnetGrid04.AulaRevisao.Domain.Entidades
{
    public class Telefone
    {
        public Guid ClienteId { get; set; }
        public string Digito { get; set; }

        public Cliente Cliente { get; set; }
    }
}
