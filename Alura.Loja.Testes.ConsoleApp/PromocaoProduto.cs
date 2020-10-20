namespace Alura.Loja.Testes.ConsoleApp
{
    // Classe de joint
    public class PromocaoProduto
    {
        // Incluindo essas propriedades "int" informa que essas propriedades são obrigatórias
        public int ProdutoId { get; set; }
        public int PromocaoId { get; set; }
        public Produto Produto { get; set; }
        public Promocao Promocao { get; set; }
    }
}
