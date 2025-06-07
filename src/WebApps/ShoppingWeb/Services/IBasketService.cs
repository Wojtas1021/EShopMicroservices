namespace ShoppingWeb.Services;

public interface IBasketService
{
    [Get("/basket-service/baskets/{userName}")]
    Task<GetBasketResponse> GetBasket(string userName);
    
    [Post("/basket-service/basket")]
    Task<StoreBasketResponse> UpdateBasket(StoreBasketRequest request);
    
    [Delete("/basket-service/basket/{userName}")]
    Task<DeleteBasketResponse> DeleteBasket(string userName);
    
    [Post("/basket-service/basket/checkout")]
    Task<CheckoutBasketResponse> Checkout(CheckoutBasketRequest request);
}
