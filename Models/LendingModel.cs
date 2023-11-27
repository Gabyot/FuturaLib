using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturaLib.Models
{
    public class LendingModel
    {
        //propiedades
        public int Order_Id { get; set; }
        public string RUT_User {  get; set; }
        public int Id_Book { get; set; }
        public string Fecha_Entrega { get; set; }
        public string Fecha_Devolucion { get; set; }
        public string Estado {  get; set; }

        //constructor 
        public LendingModel(int orderId, string rutUser, int idBook, string fechaEntrega, string fechaDevolucion,
            string estado)
        {
            Order_Id = orderId;
            RUT_User = rutUser;
            Id_Book = idBook;
            Fecha_Entrega = fechaEntrega;
            Fecha_Devolucion = fechaDevolucion;
            Estado = estado;
        }
    }
}
