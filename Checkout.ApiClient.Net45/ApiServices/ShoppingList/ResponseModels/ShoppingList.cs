using System.Collections.Generic;

namespace Checkout.ApiServices.ShoppingList.ResponseModels
{
    public class ShoppingList
    {
        public IList<ShoppingItem> ShoppingItems { get; set; }
    }
}
