using _66_MVC_ViewComponent.Models;
using _66_MVC_ViewComponent.Models.VMs;
using Microsoft.AspNetCore.Mvc;

namespace _66_MVC_ViewComponent.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var cartItems = new List<CartItem>
            {
                new CartItem { ProductName="Tuvalet Terliği", Price=1860m },
                new CartItem { ProductName="Ev Terliği", Price=1260m },
                new CartItem { ProductName="Havuz Terliği", Price=260m }
            };

            var model = new ShoppingCartVM()
            {
                CartItems = cartItems,
                Price = CalculateTotalPrice(cartItems)
            };

            return View(model);
        }

        private decimal CalculateTotalPrice(List<CartItem> cartItems)
        {
            decimal totalPrice = 0;
            foreach (var cartItem in cartItems) 
            { 
                totalPrice += cartItem.Price;
            }
            return totalPrice;
        }
    }
}
