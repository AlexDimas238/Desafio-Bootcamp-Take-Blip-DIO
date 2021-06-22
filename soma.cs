/* Primeiro desafio realizado, achei facil pois ja veio com a estrutura basicamente pronta, porem tive que interpretar
pois não sabia que os valores de input eram gerados automaticamente. foi necessário fazer uma pesquisa dos comandos.
*/

using System;

class Program
{
    static void Main(string[] args)
    {

        //Declare Variables
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        
        //Insira as variaveis de acordo com o solicitado
        int SOMA = A + B;

        //Print
        Console.WriteLine("SOMA = {0}", SOMA);

    }
}
