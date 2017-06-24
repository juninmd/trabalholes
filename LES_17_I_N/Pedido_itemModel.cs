namespace LES_17_I_N
{
    public class Pedido_itemModel
    {

        public string PEDCODI { get; set; }

        public string ITECODI { get; set; }

        public string PROCODI { get; set; }

        /// <summary>
        /// Quantidade Vendida
        /// </summary>
        public string ITEQTDE { get; set; }

        /// <summary>
        /// Valor unitario
        /// </summary>
        public string ITEVALO { get; set; }

        /// <summary>
        /// Valor Total do item ITEQTDE x ITEVALO
        /// </summary>
        public string ITETOTA { get; set; }

    }
}
