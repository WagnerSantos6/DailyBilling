using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pergunta3.Entities;

namespace Pergunta3
{
    public class Program
    {

        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\FaturamentoMensal.json");
            var factor = JsonConvert.DeserializeObject<List<Faturamento>>(json);

            Faturamento faturamento = new Faturamento();
            var menor = faturamento.menorValor(factor);
            
            Console.WriteLine("Menor valor de faturamento ocorrido em um dia do mês: " + menor);

            var maior = faturamento.maiorValor(factor);
            Console.WriteLine("Maior valor de faturamento ocorrido em um dia do mês: " + maior);

            var media = faturamento.mediaMensal(factor);
            

            var dias = faturamento.numeroDeDias(media, factor);
            Console.WriteLine(" Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: " + dias);
        }
    }
}
