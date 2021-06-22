using System;

 class MinhaClasse {
        static void Main(string[] args) {
            
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

//continue a solucao com a insercao da variavel corretamente
//Logo abaixo utilizei o resto da divisão e a lógica para ter o resultado
            if (A % B  == 0 || B % A == 0 ) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
