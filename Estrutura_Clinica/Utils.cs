using Clinica_Vet_Joana;
using System;
using System.Windows.Forms;
using System.IO;

namespace Estrutura_Clinica
{
    public class Utils
    {
        public static void LerClientes(Button btnEditar, Button btnApagar, BindingSource clienteBindingSource)
        {
            string ficheiro = "Cliente.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;

                sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                {
                    string[] colunas = linha.ToString().Split(',');

                    if (colunas.Length >= 8)
                    {
                        Cliente novoCliente = new Cliente
                        {
                            Id = Convert.ToInt32(colunas[0]),
                            Nome = colunas[1],
                            NIF = colunas[2],
                            Telemovel = colunas[3],
                            Email = colunas[4],
                        };
                        clienteBindingSource.Add(novoCliente);
                    }
                }
                sr.Close();
            }
        }
        public static void LerMedicos(Button btnEditar, Button btnApagar, BindingSource medicoBindingSource)
        {
            string ficheiro = "Medico.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;

                sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                {
                    string[] colunas = linha.ToString().Split(',');

                    if (colunas.Length >= 8)
                    {
                        Medico novoMedico = new Medico
                        {
                            Nome = colunas[0],
                            Especialidade = colunas[1],
                            Cedula = Convert.ToInt32(colunas[2]),
                            Email = colunas[3],
                            Telemovel = colunas[4],
                            NIF = colunas[5],
                            Horario = colunas[6],
                            SalaObs = colunas[7],
                        };
                        medicoBindingSource.Add(novoMedico);
                    }
                }
                sr.Close();
            }
        }
        public static void LerAnimais(Button btnEditar, Button btnApagar, BindingSource animalBindingSource)
        {
            string ficheiro = "Animal.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;

                sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                {
                    string[] colunas = linha.ToString().Split(',');

                    if (colunas.Length >= 8)
                    {
                        Animal novoAnimal = new Animal
                        {
                            Chip = Convert.ToInt32(colunas[0]),
                            Nome = colunas[1],
                            DataNascimento = Convert.ToDateTime(colunas[2]),
                            Especie = colunas[3],
                            Race = colunas[4],
                            Genero = colunas[5],
                            Peso = Convert.ToInt32(colunas[6]),
                            Esterilizacao = Convert.ToBoolean(colunas[7]),
                        };
                        animalBindingSource.Add(novoAnimal);
                    }
                }
                sr.Close();
            }
        }
        public static void LerConsultas(Button btnGuardar, Button btnCancelar, BindingSource consultasBindingSource)
        {
            string ficheiro = "Consulta.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;

                sr = File.OpenText(ficheiro);

                string linha = string.Empty;

                while ((linha = sr.ReadLine()) != null) // enquanto as linhas nao tiverem vazias
                {
                    string[] colunas = linha.ToString().Split(',');

                    if (colunas.Length >= 8)
                    {
                        Medico medicoEscolhido = new Medico();

                        Consulta novaConsulta = new Consulta
                        {
                            Id = Convert.ToInt32(colunas[0]),
                            Tratamento = colunas[1],
                           // MedicoSelecionado = 
                            DataConsulta = Convert.ToDateTime(colunas[3]),
                            ObsConsultas = colunas[4],
                        };
                        consultasBindingSource.Add(novaConsulta);
                    }
                }
                sr.Close();
            }
        }
    }
}
