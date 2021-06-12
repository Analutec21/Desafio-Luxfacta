Desafio 3

using System;
using System.Collecti.Generic;
using System.Linq
using System.Text;
using System.Threading.Tasks;

namespace Desafio 3
{
    public class Path
    {
        privat string caminho;
        public Path(string_caminho)
        { caminho=caminho;
        }
        public void cd(string comandos)
        {
            string[]comands=comandos.Split('/')
            int c = comands.Length;
            string[]diretorios=caminho.Split('/');
            int d= diretorios.Length
            string url=caminho;
            for(int x = 0;x<c;x++)
        {
            string cd = comands[x]

            if (cd==".")
            {
                url=url.Remove(url.Length-2,2);                           
            }
            if(cd!=""&&cd!=".")
            {
                url=url.Insert(url.Lenth,"."+cd)
            }
        }
        Console.Write(url);
    }
}
class Program
{
        static void Main (string[]args)
        {
            string caminho="a/b/c/d";
            Path e =new Path(caminho)
            e.cd("../e");
            Console.ReadKey();
        }
}