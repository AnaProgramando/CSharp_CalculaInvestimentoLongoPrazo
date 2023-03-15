using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CalculaInvestimentoLgPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 12 - Encadeando laços FOR: \r\n");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                // A cada ano, teremos que fazer a atualização do valorInvestido por mês, logo, teremos outro for() dentro do laço.
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    //Valor investido mês a mês
                    valorInvestido *= fatorRendimento;
                    //Seria o mesmo que fazer: valorInvestido = valorInvestido * fatorReendimento;
                }

                // Valor investido ano a ano
                // Essa é a variável que guardará o fator de rendimento e mudará ano a ano, aumentando em 0.0010, ou seja, no término do primeiro ano o valor de fatorRendimento será de 0.0046, 12 meses depois, 0.0056, subindo aos poucos até chegar no fim do período de investimento.
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido + ".");
            Console.ReadLine();
        }
    }
}
