using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juridico
{
    public class processo
    {
        public int numero { get; set; }
        public DateTime datacriacao { get; set; } 
        public Pessoa solicitante { get; set; }
        public Pessoa Acusado { get; set; }
        public Pessoa pedido  { get; set; }

        public List<pessoa> listajuridica()
        {
            return null;
        }
        public List<pessoa> listaFísica()
        {
            return null;
        }

    }

}
    }
}
