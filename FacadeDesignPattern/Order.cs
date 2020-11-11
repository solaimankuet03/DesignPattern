using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class Order //Facade - this class acts as a wrapper to the subclasses
    {
        public void PlaceOrder()
        {
            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.Sendinvoice();            
        }
    }
}
