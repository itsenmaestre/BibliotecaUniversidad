using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PedidoRepositoryTxt : IPedidoRepository
    {
        private string Ruta = "PedidosBiblioteca.txt";
        public List<Pedido> ObtenerTodos()
        {
            try
            {
                List<Pedido> Lista = new List<Pedido>();
                StreamReader Lector = new StreamReader(Ruta);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
