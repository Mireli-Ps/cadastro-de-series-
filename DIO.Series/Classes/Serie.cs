namespace DIO.Series
{
    // Atributos
    public class Serie : EntidadeBase   
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao{ get; set ;}
        private int Ano {get; set;}
        
    //metodos 
        public Serie ( int id,Genero genero,string titulo, string descricao,int ano)
        {
            this.id =id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;

        }
        
    }
}