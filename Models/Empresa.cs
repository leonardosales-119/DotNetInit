using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace comeiaT.Models
{
    public class Empresa
    {
        [Key]
        public int ID { get; set; }

        public string CNPJ { get; set; }

        public string NOME_FANTASIA { get; set; }

        public string TELEFONE { get; set; }

        public string EMAIL { get; set; }

        public DateTime DATA_DO_CADASTRO { get; set; } = DateTime.Now;


     }
}
