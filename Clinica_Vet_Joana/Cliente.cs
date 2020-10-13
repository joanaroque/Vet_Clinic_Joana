using System;
using System.Collections.Generic;

namespace Clinica_Vet_Joana
{
    public class Cliente
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string NIF { get; set; }

        public string Telemovel { get; set; }

        public string Email { get; set; }

        public List<Animal> Animais { get; set; } = new List<Animal>();

        public const string FicheiroClientes = "Clientes.txt";

        public override string ToString()
        {
            return $"{Nome}";
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        public Cliente()
        {

        }
    }
}
