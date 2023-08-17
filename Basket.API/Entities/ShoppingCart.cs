using System.Collections.Generic;
using System.Linq;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
            Items = new List<ShoppingCartItem>();
        }

        public decimal TotalPrice
        {
            get { return Items.Sum(item => item.Price * item.Quality); }
        }
    }
}