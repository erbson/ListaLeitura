using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListaLeitura
{
    class Curso
    {
      
     
        private string instrutor;
        private string nome;


        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
       
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public Curso(string instrutor, string nome)
        {
            this.instrutor = instrutor;
            this.nome = nome;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    

        public string Instrutor 
        {
            get { return instrutor; }
            set { instrutor = value; }
        }
       

        public int TempoTotal
        {
            get {
                //int total = 0;

                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}

                return aulas.Sum(aula => aula.Tempo);
            
            
            
            }
           
        }

        public override string ToString()
        {
            return $"Nome:{nome},Tempo{TempoTotal},Aulas{string.Join(",",aulas)}";
        }


    }
}
