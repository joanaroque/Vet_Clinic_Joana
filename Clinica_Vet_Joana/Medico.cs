using System;

namespace Clinica_Vet_Joana
{
    public class Medico
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Especialidade { get; set; }

        public int Cedula { get; set; }

        public string NIF { get; set; }

        public string Telemovel { get; set; }

        public string Email { get; set; }

        public string Horario { get; set; }

        public string SalaObs { get; set; }

        public const string FicheiroMedicos = "Medicos.txt";

        public override string ToString()
        {
            return Nome;
        }

        public Medico(string nome)
        {
            this.Nome = nome;
        }
        public Medico()
        {

        }
    }
}
