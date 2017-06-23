namespace LES_17_I_N
{
    public class ProdutoModel
    {
        public int PROCODI { get; set; }

        public string PRONOME { get; set; }

        /// <summary>
        /// Pre�o custo
        /// </summary>
        public double PROCUST { get; set; }

        /// <summary>
        /// Margem Lucro
        /// </summary>
        public double PROMARG { get; set; }

        /// <summary>
        /// Pre�o Venda
        /// </summary>
        public double PROVEND { get; set; }

        /// <summary>
        /// Qtd Estoque
        /// </summary>
        public string PROESTO { get; set; }

        /// <summary>
        /// Localiza��o do produto
        /// </summary>
        public string PROLOCA { get; set; }

        /// <summary>
        /// Observa��o
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
