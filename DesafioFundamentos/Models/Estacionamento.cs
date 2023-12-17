using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial = 5;
        private decimal PrecoPorHora = 2;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal PrecoInicial, decimal PrecoPorHora)
        {
            this.PrecoInicial = PrecoInicial;
            this.PrecoPorHora = PrecoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar: (ex: KKS8806)");
            string addPlacaNoSistema = Console.ReadLine();

            Console.WriteLine("Verificando se sua placa já está no sistema");
            System.Threading.Thread.Sleep(1500);

            if (veiculos.Any(x => x.ToUpper() == addPlacaNoSistema.ToUpper()))
            {
                Console.WriteLine("Ops, a usa placa já existe em nosso sistema!");
            } 
            else 
            {
                veiculos.Add(addPlacaNoSistema);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\n Sua placa está válida! A registrar no sistema... \n");

                int cont = 0;
                foreach(string valor in veiculos){
                    cont++;
                    System.Console.WriteLine($"{cont}º placa cadastrada no sistema: {valor}");
                }
            }
        }



        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            Console.WriteLine("Verificando veículo...");
            System.Threading.Thread.Sleep(1000);

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = PrecoInicial + (PrecoPorHora * horas);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida para horas. Certifique-se de digitar um número inteiro.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
