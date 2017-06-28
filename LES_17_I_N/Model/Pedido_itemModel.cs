namespace LES_17_I_N.Model
{
    public class Pedido_itemModel
    {

        public int PEDCODI { get; set; }

        public int ITECODI { get; set; }

        public int PROCODI { get; set; }

        /// <summary>
        /// Quantidade Vendida
        /// </summary>
        public int ITEQTDE { get; set; }

        /// <summary>
        /// Valor unitario
        /// </summary>
        public double ITEVALO { get; set; }

        /// <summary>
        /// Valor Total do item ITEQTDE x ITEVALO
        /// </summary>
        public double ITETOTA { get; set; }

    }
}
