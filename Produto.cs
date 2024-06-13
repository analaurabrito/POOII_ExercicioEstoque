using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTel003
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string quantidade { get; set; }

        public Produto() { }
        public Produto(int id, string nome, string marca, string quantidade)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.quantidade = quantidade;
        }
    }
}
