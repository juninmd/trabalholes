namespace LES_17_I_N
{
    public class ProdutoModel
    {
        public int PROCODI { get; set; }

        public string PRONOME { get; set; }

        /// <summary>
        /// Preço custo
        /// </summary>
        public double PROCUST { get; set; }

        /// <summary>
        /// Margem Lucro
        /// </summary>
        public double PROMARG { get; set; }

        /// <summary>
        /// Preço Venda
        /// </summary>
        public double PROVEND { get; set; }

        /// <summary>
        /// Qtd Estoque
        /// </summary>
        public string PROESTO { get; set; }

        /// <summary>
        /// Localização do produto
        /// </summary>
        public string PROLOCA { get; set; }

        /// <summary>
        /// Observação
        /// </summary>
        public string PROOBS { get; set; }


        /// <summary>
        /// FK UNIDADE
        /// </summary>
        public string UNICODI { get; set; }

        /// <summary>
        /// FK GRUPO
        /// </summary>
        public string GRUCODI { get; set; }

    }
}
