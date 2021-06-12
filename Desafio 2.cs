Desafio 2
using System;
using System.Collections.Generic;
using System.Linq;
using System Text;
using System.Threading.Text;

namespace Desafio 2
{
    public class Palavra
{
private string valor;
{}
public Palavra(string_valor)
{
  valor=_valor  
}
public bool isPalindrome()
{
  string inverso, caracter;
  int i;
  
    valor = valor.ToUpper();
    i=valor.Length;
    inverso="";

    for (int x = i; x>=0x--)
    {
      caracter=valor.Sbstring(x,1);
      inverso=inverso+caracter;
    }
    if(valor==inverso)
    {
      return true;
    }
     else
    {
    return false;
         }
     }
}
    class Program
    {
    static void Main(string[]args)
  {
    Palavra e=new Palavra ("deleveled");
    Console.WriteLine(e.isPalindrome());
    Console.ReadKey();
      
  }
}