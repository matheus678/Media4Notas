using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: Media4Notas] Receba 4 notas, com somente uma casa decimal. Valide se todas estão entre 0.0 e 10.0. Se alguma delas não estiver, exiba "Digite somente notas entre 0 e 10.". Caso todas as notas sejam válidas, calcule a média aritmética das notas. Exiba uma mensagem no seguinte padrão: "Você ficou com média 7,5. Resultado: Aprovado".
            Resultados possíveis:
            "Reprovado" para médias menores que 5.0
            "Em recuperação" para médias entre 5.0 e 6.0
            "Aprovado", para médias acima de 6.0
            Ex.:
            -- Média --

            Digite as suas notas abaixo.
            Nota 1: 5,5
            Nota 2: -7,0
            Nota 3: 10,5
            Nota 4: 9,0

            Digite somente notas entre 0 e 10.
            ou
            -- Média --

            Digite as suas notas abaixo.
            Nota 1: 5,5
            Nota 2: 7,0
            Nota 3: 6,5
            Nota 4: 9,0

            Você ficou com média 7,0. Resultado: Aprovado
            ou
            -- Média --

            Digite as suas notas abaixo.
            Nota 1: 4,5
            Nota 2: 3,0
            Nota 3: 6,5
            Nota 4: 2,0

            Você ficou com média 4,0. Resultado: Reprovado
            ou
            -- Média --

            Digite as suas notas abaixo.
            Nota 1: 6,5
            Nota 2: 6,5
            Nota 3: 6,5
            Nota 4: 6,5

            Você ficou com média 6,5. Resultado: Em recuperação
            */

            decimal NotaAluno1;
            decimal NotaAluno2;
            decimal NotaAluno3;
            decimal NotaAluno4;
            decimal MediaFinal;

            Console.WriteLine("Olá aluno, irei mostrar se você foi aprovao, reprovado ou está de recuperação");

            
            // Cada um desses números representará a nota desde a priemria até a quarta.
            // MediaFinal será o valor dado após a adição entre todas as notas dividida por 4.
 
            Console.Write("Digite seu primeira nota...:");
            1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua segunda nota...:");
            2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua terceira nota...:");
            3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua quarta nota...:");
            4 = Convert.ToDouble(Console.ReadLine());

            MediaFinal = (1 + 2 + 3 + 4) / 4;

            if ( MediaFinal >5.0 )
            {
                Console.Write($"Sua média final foi {MediaFinal} Infelizmente você foi reprovado!");
            }

            else ( MediaFinal >=5,0 && MediaFinal <=6.0 )
            {
                Console.Write($"Sua média final foi {MediaFinal} Infelizmente você está de recuperação!");
            }
 
            else if ( MediaFinal >6.0 )
            {
                Console.Write($"Sua média final foi {MediaFinal} Parabéns, você foi aprovado!");
            }
                
        }  
    }
}
