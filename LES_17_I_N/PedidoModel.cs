using System;

namespace LES_17_I_N
{
    public class PedidoModel
    {

        public int PEDCODI { get; set; }

        /// <summary>
        /// Data de Emissão
        /// </summary>
        public DateTime PEDDTEM { get; set; }

        /// <summary>
        /// Data de Baixa
        /// </summary>
        public DateTime PEDDTBA { get; set; }

        /// <summary>
        /// Total do Pedido
        /// </summary>
        public double PEDTOTA { get; set; }


        /// <summary>
        /// Percentual de Desconto
        /// </summary>
        public double PEDPERC { get; set; }


        /// <summary>
        /// Valor de Desconto
        /// </summary>
        public double PEDDESC { get; set; }

        /// <summary>
        /// PEDTOTA - PEDDESC
        /// </summary>
        public double PEDLIQU { get; set; }

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
        public int CLICODI { get; set; }

        /// <summary>
        /// Vendedor Codi
        /// </summary>
        public int FUNCODI { get; set; }

    }
}
