using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramaP2.Class;

public class Anagram
{
    public static Dictionary<char, int> ContarRepeticoes(string palavra)
    {
        Dictionary<char, int> repeticoes = new Dictionary<char, int>();

        foreach (char valor in palavra)
        {
            if (repeticoes.ContainsKey(valor))
            {
                repeticoes[valor]++;
            }
            else
            {
                repeticoes[valor] = 1;
            }
        }
        return repeticoes;
    }



    public static string RemoverRepeticoes(string palavra)
    {
        List<char> valorUnico = new List<char>();

        foreach (char valor in palavra)
        {
            if (!valorUnico.Contains(valor))
            {
                valorUnico.Add(valor);  
            }
        }
        return new string(valorUnico.ToArray());
    }

    public static int CalcularFatorial(int numero)
    {
        if(numero <= 1)
        {
            return 1;
        }

        int resultado = 1;

        for(int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
    public static int CalculaAnagrama(string palavra)
    {
        int totalDePossibilidades = CalcularFatorial((palavra.Length));
        Dictionary<char, int> repeticoes = ContarRepeticoes(palavra);

        foreach (int valor in repeticoes.Values)
        {
            totalDePossibilidades /= CalcularFatorial(valor);
        }
        return totalDePossibilidades;
    }
}
