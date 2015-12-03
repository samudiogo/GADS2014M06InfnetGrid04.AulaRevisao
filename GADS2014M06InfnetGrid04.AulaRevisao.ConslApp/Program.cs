
using System;
using System.Collections.Generic;
using System.Linq;
using GADS2014M06InfnetGrid04.AulaRevisao.Domain.Entidades;

namespace GADS2014M06InfnetGrid04.AulaRevisao.ConslApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var walllace = new Cliente();
            var gui = new Cliente(); // =// new Cliente();
            walllace.Nome = "Wallace";
            walllace.Cpf = "7897987979";
            walllace.Cnh = "789798798797";
            walllace.Endereco = "mora mal";
            var wTelefones = new List<Telefone> {new Telefone {Cliente = walllace, Digito = "8080808"}};
            walllace.Telefones = wTelefones;


            Console.WriteLine(walllace.Telefones.First().Digito);

            walllace.Anda();
            walllace.Fala();
        }
    }
}
