using System;

namespace DesafioFundamentos.Models
{
    class Estacionamento
    {
        private decimal PrecoInicial { get; }
        private decimal PrecoPorHora { get; }

        // Lista para armazenar veículos
        private List<Veiculo> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
            veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();

            // Crie um novo objeto Veiculo
            Veiculo novoVeiculo = new Veiculo(placa, modelo);

            // Adicione o veículo à lista
            veiculos.Add(novoVeiculo);

            Console.WriteLine($"Veículo {modelo} cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo a ser removido:");
            string placa = Console.ReadLine();

            // Encontre o veículo na lista
            Veiculo veiculoRemover = veiculos.FirstOrDefault(v => v.Placa == placa);

            if (veiculoRemover != null)
            {
                // Remova o veículo da lista
                veiculos.Remove(veiculoRemover);
                Console.WriteLine($"Veículo {veiculoRemover.Modelo} removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de veículos estacionados:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}");
            }
        }
    }

    class Veiculo
    {
        public string Placa { get; }
        public string Modelo { get; }

        public Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
        }
    }
}