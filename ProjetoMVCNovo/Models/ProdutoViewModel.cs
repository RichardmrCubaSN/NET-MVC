namespace ProjetoMVCNovo.Models
{ 
    public class ProdutoViewModel
    {
        public ProdutoViewModel(string descricao)
        {
            Descricao = descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }

        internal void Add(object produto)
        {
            throw new NotImplementedException();
        }
    }
}
