using System;
namespace DIO.Series
{
    // Atributos
    public class Serie : EntidadeBase   
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao{ get; set ;}
        private int Ano {get; set;}
        private bool Excluido{get; set;}
        
    //metodos 
        public Serie ( int id,Genero genero,string titulo, string descricao,int ano)
        {
            this.id =id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;

        }
        public override string ToString(){ 
            
            string retorno = "";
            retorno += "Gênero : " + this.Genero + Environment.NewLine;
            retorno += "Titulo : " + this.Titulo + Environment.NewLine;
            retorno +="Descricao: "+ this.Descricao+ Environment.NewLine;
            retorno += "Ano de Início : " + this.Ano + Environment.NewLine;
            return retorno;

        }
        public int retornaId ()
        {
            return this.id;
        }
        public string retornaTitulo ()
        {
            return this.Titulo;    
        }
        public void  Excluir()
        {
            this.Excluido = true;
        }
    }
}