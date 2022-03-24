using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{

    internal class Calculo
    {
        public void Apresentar()
        {
            Data datas = new Data();
            Relatorio relatorio = new Relatorio();

            datas.DataAtual = DateTime.Now;
            Console.WriteLine(datas.DataAtual.ToString());

            datas.Data1 = new DateTime(2022, 02, 24, 0, 0, 0);
            Console.WriteLine(datas.Data1.ToString());

            datas.Diferenca = datas.Data1 - datas.DataAtual;

            Console.WriteLine("---------------------------------------");

            relatorio.Apresentar();

            Console.WriteLine("---------------------------------------");

            if (datas.Diferenca.Days == -1)
            {
                Console.WriteLine("Um dia atras");
            }
            else if (datas.Diferenca.Days == -2)
            {
                Console.WriteLine("Dois dias atras");
            }
            else if (datas.Diferenca.Days == -7)
            {
                Console.WriteLine("Uma semana atrás");
            }
            else if (datas.Diferenca.Days >= -31)
            {
                Console.WriteLine("Um mês atrás");
            }
            else if (datas.Diferenca.Days >= -365)
            {
                Console.WriteLine("Um ano atrás");
            }
        }
    }
}
