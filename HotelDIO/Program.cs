using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using HotelDIO.Models;

namespace HotelDIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Cria os hóspedes e cadastra na lista
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa pessoa1 = new Pessoa
            {
                Nome = "Carlos",
                Sobrenome = "Augusto"
            };

            Pessoa pessoa2 = new Pessoa
            {
                Nome = "Acácio",
                Sobrenome = "de Sá"
            };

            Pessoa pessoa3 = new Pessoa
            {
                Nome = "Ana",
                Sobrenome = "Maria"
            };

            hospedes.Add(pessoa1);
            hospedes.Add(pessoa2);
            hospedes.Add(pessoa3);

            // Cria a suíte
            Suite suite = new Suite
            {
                TipoSuite = "Premium",
                Capacidade = 4,
                ValorDiaria = 30.00M
            };

            // Cria a reserva
            Reserva reserva = new Reserva
            {
                DiasReservados = 10
            };
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            //Mostrar qtd de Hóspedes e Valor Total
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");

            Console.ReadKey();



            Console.ReadKey();
        }
    }
}
