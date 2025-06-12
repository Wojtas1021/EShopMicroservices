namespace ShoppingWeb.Services;

public interface IBasketService
{
    [Get("/basket-service/baskets/{userName}")]
    Task<GetBasketResponse> GetBasket(string userName);
    
    [Post("/basket-service/basket")]
    Task<StoreBasketResponse> StoreBasket(StoreBasketRequest request);
    
    [Delete("/basket-service/basket/{userName}")]
    Task<DeleteBasketResponse> DeleteBasket(string userName);
    
    [Post("/basket-service/basket/checkout")]
    Task<CheckoutBasketResponse> Checkout(CheckoutBasketRequest request);

    public async Task<ShoppingCartModel> LoadUserBasket()
    {
        var userName = "swn";
        ShoppingCartModel basket;

        try
        {
            var getBasketResponse = await GetBasket(userName);
            basket = getBasketResponse.Cart;
        }
        catch (Exception)
        {
            basket = new ShoppingCartModel
            {
                UserName = userName,
                Items = []
            };
        }

        return basket;
    }
}
