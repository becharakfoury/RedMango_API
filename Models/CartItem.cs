using System.ComponentModel.DataAnnotations.Schema;

namespace RedMango_API.Models
{
    public class CartItem
    {
        public int Id { get; set; }
		
        public int MenuItemId { get; set; }
        [ForeignKey("MenuItemId")] //Foreign key reference to Menuitem table
        public MenuItem MenuItem { get; set; } = new(); // Navigation property
        
		public int Quantity { get; set; }
		
        public int ShoppingCartId { get; set; } // reference to shopping cart Id
    }
}
