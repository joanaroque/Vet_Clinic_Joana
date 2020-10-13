using System;

namespace Clinica_Vet_Joana
{
    public class Animal
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public string Genero { get; set; }

        public double Peso { get; set; }

        public bool Esterilizacao { get; set; }

        public DateTime DataNascimento { get; set; }

        public const string FicheiroAnimais = "Animais.txt";

        public override string ToString()
        {
            return Nome;
        }

        public Animal(string nome)
        {
            Nome = nome;
        }
        public Animal()
        {

        }
    }
}