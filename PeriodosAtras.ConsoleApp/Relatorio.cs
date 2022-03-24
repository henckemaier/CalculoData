using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    internal class Relatorio
    {
        public void Apresentar()
        {
            Data datas = new Data();

            Console.WriteLine("Dias Passados: " + datas.Diferenca.Days);
            Console.WriteLine("Horas Passadas: " + datas.Diferenca.Hours);
            Console.WriteLine("Minutos Passados: " + datas.Diferenca.Minutes);
            Console.WriteLine("Segundos Passados: " + datas.Diferenca.Seconds);
        }

    }
}
