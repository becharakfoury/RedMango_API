using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace RedMango_API.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
		
        public string UserId { get; set; } // ==> linked to AspNetUsers (linked to a varchar that store GUID)
        
		public ICollection<CartItem> CartItems { get; set; } // ==> one Shopping cart, can have one of more CartItem / represent one to many relation

        [NotMapped] // property will be in the model but not in the database
        public double CartTotal { get; set; }
        [NotMapped]
        public string StripePaymentIntentId { get; set; } //==> provide by payament gateway, no need to save them in database
        [NotMapped]
        public string ClientSecret { get; set; }  //==> provide by payament gateway, no need to save them in database
    }

   
}
