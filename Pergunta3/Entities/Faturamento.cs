using System.Collections.Generic;
using System.Linq;


namespace Pergunta3.Entities
{
    public class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }

        public double menorValor (List<Faturamento> fat)
        {
          var menor = fat.Select(x => x.Valor).Where(x => x > 0).ToList().Min();
            return menor;
        }

        public double maiorValor (List<Faturamento> fat)
        {
            var maior = fat.Select(x => x.Valor).ToList().Max();
            return maior;
        }

        public double mediaMensal (List<Faturamento> fat)
        {
            int contador = 0;
            double sumTotal = 0;
            foreach ( Faturamento list in fat)
            {
                if (list.Valor > 0)
                {
                    contador++;
                }
                sumTotal = sumTotal + list.Valor;
            }
            var media = sumTotal / contador;
            return media;
        }

        public int numeroDeDias (double media, List<Faturamento> fat)
        {
            int contador = 0;
                
                foreach (Faturamento list in fat)
                {
                    if (list.Valor > media)
                    {
                       contador++;
                    }
                }
            return contador;
        }
    }
}
