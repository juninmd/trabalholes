namespace LES_17_I_N
{
    public class PedidoModel
    {

        public int PEDCODI { get; set; }

        /// <summary>
        /// Data de Emissão
        /// </summary>
        public string PEDDTEM { get; set; }

        /// <summary>
        /// Data de Baixa
        /// </summary>
        public string PEDDTBA { get; set; }

        /// <summary>
        /// Total do Pedido
        /// </summary>
        public string PEDTOTA { get; set; }


        /// <summary>
        /// Percentual de Desconto
        /// </summary>
        public string PEDPERC { get; set; }


        /// <summary>
        /// Valor de Desconto
        /// </summary>
        public string PEDDESC { get; set; }

        /// <summary>
        /// PEDTOTA - PEDDESC
        /// </summary>
        public string PEDLIQU { get; set; }

        /// <summary>
        /// Condição de Pagamento
        /// </summary>
        public string PEDCOND { get; set; }

        /// <summary>
        /// Observação
        /// </summary>
        public string PEDOBS { get; set; }

        /// <summary>
        /// Cli Codi
        /// </summary>
        public string CLICODI { get; set; }

        /// <summary>
        /// Vendedor Codi
        /// </summary>
        public string FUNCODI { get; set; }

    }
}
