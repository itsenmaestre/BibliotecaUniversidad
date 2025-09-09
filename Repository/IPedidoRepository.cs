using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Repository
{
    internal interface IPedidoRepository
    {
        List <Pedido> ObtenerTodos ();
        void Save(Pedido pedido);

    }
}
