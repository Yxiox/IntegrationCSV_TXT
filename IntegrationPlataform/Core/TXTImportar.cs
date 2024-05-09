using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TXTImportar
    {
        string dados = File.ReadAllText("C:\\Users\\Gabriel.T\\Desktop\\testeTXT.txt");

        string genero;
        string categoria;
        string midia;
        string tipoMidia;
        int classificacao;
        string paricipante;

        public void readtxt()
        {
            for (int i = 0; i < 20; i++)
            {
                 genero += dados[i];  
            }

            for (int i = 21; i < 70; i++)
            {
                categoria += dados[i];
            }
            for (int i = 71; i < 120; i++)
            {
                midia += dados[i];
            }
            for (int i = 121; i < 170; i++)
            {
                tipoMidia += dados[i];
            }
            string temp = "";
            for (int i = 171; i < 174; i++)
            {
                temp += dados[i];
            }
                classificacao += Convert.ToInt32(temp);
            for (int i = 174; i < 273; i++)
            {
                paricipante += dados[i];
            }
            Console.WriteLine(genero);
            Console.WriteLine(categoria);
            Console.WriteLine(midia);
            Console.WriteLine(tipoMidia);
            Console.WriteLine(classificacao);
            Console.WriteLine(paricipante);
        }

        }

    }



