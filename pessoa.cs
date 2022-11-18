using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juridico.Models 
{
    public class pessoa
    {
        public int numro { get; set; }
        public char TipoPessoa { get; set; }//F= física , J = jurídica 
        public string Nome { get; set; }
        public string Endereço { get; set; }

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
