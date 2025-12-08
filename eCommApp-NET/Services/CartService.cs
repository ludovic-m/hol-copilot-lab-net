using eCommApp_NET.Models;

namespace eCommApp_NET.Services;

public class CartService
{
    private List<CartItem> _cartItems = new();
    
    public event Action? OnChange;

    public IReadOnlyList<CartItem> CartItems => _cartItems.AsReadOnly();

    public void AddToCart(Product product)
    {
        var existingItem = _cartItems.FirstOrDefault(item => item.Id == product.Id);
        
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            _cartItems.Add(CartItem.FromProduct(product));
        }
        
        NotifyStateChanged();
    }

    public void ClearCart()
    {
        _cartItems.Clear();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
