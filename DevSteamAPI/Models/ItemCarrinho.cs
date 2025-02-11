namespace DevSteamAPI.Models
{
    public class ItemCarrinho
    {
        public Guid ItemCarrinhoId { get; set; }
        public Guid CarrinhoId { get; set; }
        public Guid JogoId { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
    }
}
