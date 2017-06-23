using System;

namespace LES_17_I_N
{
    public class ClienteModel
    {

        public int CLICODI { get; set; }

        public string CLINOME { get; set; }

        /// <summary>
        /// Nome Fantasia
        /// </summary>
        public string CLIFANT { get; set; }

        /// <summary>
        /// Apelido do cliente
        /// </summary>
        public string CLIAPEL { get; set; }

        /// <summary>
        /// Limite para compra
        /// </summary>
        public double CLILIMI { get; set; }

        /// <summary>
        /// Data data da primeira compra
        /// </summary>
        public DateTime? CLIDTIN { get; set; }

        public string CLICNPJ { get; set; }

        /// <summary>
        /// Inscrição Estadual
        /// </summary>
        public string CLIINES { get; set; }

        public string CLIEMAI { get; set; }

        public string CLIFONE { get; set; }

        public string CLICELU { get; set; }

        public string CLICEL1 { get; set; }

        /// <summary>
        /// Numero da rua do cliente
        /// </summary>
        public string CLINUME { get; set; }

        public int CLISTAT { get; set; }

        public string ENDCEP { get; set; }

    }
}
