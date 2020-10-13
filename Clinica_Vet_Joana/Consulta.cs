using System;

namespace Clinica_Vet_Joana
{
    public class Consulta
    {
        public string Id { get; set; }

        public string Tratamento { get; set; }

        public Medico MedicoSelecionado { get; set; }

        public Animal NomeAnimal { get; set; }

        public DateTime DiaConsulta { get; set; }

        public string HoraConsulta { get; set; }

        public Cliente NomeCliente { get; set; }

        public string ObsConsultas { get; set; }

        public const string FicheiroConsultas = "Consultas.txt";

        public Consulta(string tratamento, string obsConslt, Medico nome, DateTime data)
        {
            Tratamento = tratamento;
            ObsConsultas = obsConslt;
            MedicoSelecionado = nome;
            DiaConsulta = data;
        }
        public Consulta()
        {

        }
    }
}
