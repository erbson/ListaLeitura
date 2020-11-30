using System;
using System.Collections.Generic;

namespace ListaLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharp = new Curso("Erbson Lavras", "Coleçoes em C#");

            //  csharp.Aulas.Add(new Aula("Trabalhando com listas", 15));
            csharp.Adiciona(new Aula("Trabalhando com listas", 15));
            imprimir(csharp.Aulas);


            Console.WriteLine("_______________________________ Adicionando novas Aulas");

            csharp.Adiciona(new Aula("Aula de Lista", 35));
            csharp.Adiciona(new Aula("Coleçoes em c#", 45));
            imprimir(csharp.Aulas);


            Console.WriteLine("_______________________________ Ordenando as aulas");

            // antes copiaremos as lista para uma nova lista que não seja o Ilist

            List<Aula> aulascopiadas = new List<Aula>(csharp.Aulas);
            aulascopiadas.Sort();
            imprimir(aulascopiadas);

            Console.WriteLine("_______________________________ totalizando o tempo das aulas");
            Console.WriteLine(csharp.TempoTotal);

            Console.WriteLine("_______________________________ imprimindo o curso ");

            Console.WriteLine(csharp);






        }




        private static void imprimir(IList<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
