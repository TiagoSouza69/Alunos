using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
          
          int QTD;
          Console.WriteLine("Informe o número de aluno que deseja cadastrar:");
             QTD = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[QTD];
            var indicealuno = 0;
           string opcaousuario = obteropcaouser();

            while (opcaousuario.ToUpper() != "X")
            {
                switch(opcaousuario)
                {
                    case "1":
                     Console.WriteLine("Informe o nome do Aluno:");
                     Aluno aluno = new Aluno();
                     aluno.Nome = Console.ReadLine();

                     Console.WriteLine("Informe a nota do aluno:");
                      if (decimal.TryParse(Console.ReadLine(), out decimal nota));
                      {
                          aluno.Notas = nota;
                      }
                      
                      alunos[indicealuno] = aluno;
                      indicealuno++;
                    break;
                    
                    case "2":
                      foreach (var a in alunos)
                      
                      Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Notas}");
                      
                    break;

                    case "3":
                     decimal notatotal = 0;
                     var nrAlunos = 0;
                           for (int i =0; i < alunos.Length; i++)
                           {
                             notatotal = notatotal + alunos[i].Notas;
                             nrAlunos++;
                           }
                           var mediageral = notatotal / nrAlunos;
                           Console.WriteLine($"Média geral da nota da turma é:{mediageral}");
                    break;

                    default:
                     throw new ArgumentOutOfRangeException("Opção invalida!");

                }
               opcaousuario= obteropcaouser();   
            } 
              
        }
          private static string obteropcaouser()
            {
            Console.WriteLine("__________________________________");
            Console.WriteLine("Informe a sua opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Lista alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("__________________________________");
           
           string opcaousuario = Console.ReadLine(); 
           return opcaousuario;
          }

    }
}
