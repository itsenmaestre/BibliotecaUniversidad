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
                while (!Lector.EndOfStream)
                {
                    Lista.Add(Mappear(Lector.ReadLine));
                }
                Lector.Close();
                return Lista;

            }
            catch (Exception)
            {

                return null;
            }
        }

        private Pedido Mappear(string linea)
        {
            Pedido Usuario = new Pedido();
            //var aux = linea.Split(';');

            Usuario.Libro = linea.Split(';')[0];
            Usuario.Estudiante = linea.Split(';')[1];
            
            return Usuario;
        }

        public void Save(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
