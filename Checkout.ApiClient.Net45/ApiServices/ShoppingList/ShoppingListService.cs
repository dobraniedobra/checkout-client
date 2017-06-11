using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.ShoppingList.RequestModels;
using Checkout.ApiServices.ShoppingList.ResponseModels;

namespace Checkout.ApiServices.ShoppingList
{
    public class ShoppingListService
    {
        public HttpResponse<OkResponse> CreateDrink(ShoppingItemCreate shoppingItemCreateRequest)
        {
            var createShoppingItemkUri = ApiUrls.ShoppingItem;
            return new ApiHttpClient().PostRequest<OkResponse>(createShoppingItemkUri, AppSettings.SecretKey, shoppingItemCreateRequest);
        }

        public HttpResponse<OkResponse> RemoveDrink(string shoppingItemName)
        {
            var deleteShoppingItemUri = string.Format(ApiUrls.ShoppingItem, shoppingItemName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteShoppingItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> UpdateDrink(string shoppingItemName, int newQuantity)
        {
            var updateShoppingItemUri = string.Format(ApiUrls.ShoppingItemUpdate, shoppingItemName, newQuantity);
            return new ApiHttpClient().PutRequest<OkResponse>(updateShoppingItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<ShoppingItem> GetDrink(string shoppingItemName)
        {
            var getShoppingItemUri = string.Format(ApiUrls.ShoppingItem, shoppingItemName);
            return new ApiHttpClient().GetRequest<ShoppingItem>(getShoppingItemUri, AppSettings.SecretKey);
        }

        public HttpResponse<ResponseModels.ShoppingList> GetDrinks()
        {
            var getShoppingListUri = string.Format(ApiUrls.ShoppingList);
            return new ApiHttpClient().GetRequest<ResponseModels.ShoppingList>(getShoppingListUri, AppSettings.SecretKey);
        }
    }
}
