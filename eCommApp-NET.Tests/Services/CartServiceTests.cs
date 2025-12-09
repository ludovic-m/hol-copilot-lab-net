using Xunit;
using eCommApp_NET.Services;
using eCommApp_NET.Models;

namespace eCommApp_NET.Tests.Services;

public class CartServiceTests
{
    [Fact]
    public void CartItems_ShouldBeEmpty_WhenServiceIsCreated()
    {
        // Arrange & Act
        var cartService = new CartService();

        // Assert
        Assert.Empty(cartService.CartItems);
    }

    [Fact]
    public void AddToCart_ShouldAddNewItem_WhenProductNotInCart()
    {
        // Arrange
        var cartService = new CartService();
        var product = new Product
        {
            Id = "1",
            Name = "Test Product 1",
            Price = 29.99m,
            Description = "Test Description",
            Image = "test1.jpg",
            InStock = true,
            Reviews = new List<Review>()
        };

        // Act
        cartService.AddToCart(product);

        // Assert
        Assert.Single(cartService.CartItems);
        Assert.Equal(1, cartService.CartItems[0].Quantity);
        Assert.Equal(product.Id, cartService.CartItems[0].Id);
        Assert.Equal(product.Name, cartService.CartItems[0].Name);
        Assert.Equal(product.Price, cartService.CartItems[0].Price);
    }

    [Fact]
    public void AddToCart_ShouldIncreaseQuantity_WhenProductAlreadyInCart()
    {
        // Arrange
        var cartService = new CartService();
        var product = new Product
        {
            Id = "1",
            Name = "Test Product 1",
            Price = 29.99m,
            Description = "Test Description",
            Image = "test1.jpg",
            InStock = true,
            Reviews = new List<Review>()
        };

        // Act
        cartService.AddToCart(product);
        cartService.AddToCart(product);

        // Assert
        Assert.Single(cartService.CartItems);
        Assert.Equal(2, cartService.CartItems[0].Quantity);
    }

    [Fact]
    public void ClearCart_ShouldRemoveAllItems()
    {
        // Arrange
        var cartService = new CartService();
        var product1 = new Product
        {
            Id = "1",
            Name = "Test Product 1",
            Price = 29.99m,
            Image = "test1.jpg",
            InStock = true
        };
        var product2 = new Product
        {
            Id = "2",
            Name = "Test Product 2",
            Price = 49.99m,
            Image = "test2.jpg",
            InStock = true
        };

        cartService.AddToCart(product1);
        cartService.AddToCart(product2);

        // Act
        cartService.ClearCart();

        // Assert
        Assert.Empty(cartService.CartItems);
    }

    [Fact]
    public void OnChange_ShouldTriggerEvent_WhenItemIsAdded()
    {
        // Arrange
        var cartService = new CartService();
        var eventTriggered = false;
        cartService.OnChange += () => eventTriggered = true;
        var product = new Product
        {
            Id = "1",
            Name = "Test Product",
            Price = 19.99m,
            Image = "test.jpg",
            InStock = true
        };

        // Act
        cartService.AddToCart(product);

        // Assert
        Assert.True(eventTriggered);
    }

    [Fact]
    public void OnChange_ShouldTriggerEvent_WhenCartIsCleared()
    {
        // Arrange
        var cartService = new CartService();
        var product = new Product
        {
            Id = "1",
            Name = "Test Product",
            Price = 19.99m,
            Image = "test.jpg",
            InStock = true
        };
        cartService.AddToCart(product);

        var eventTriggered = false;
        cartService.OnChange += () => eventTriggered = true;

        // Act
        cartService.ClearCart();

        // Assert
        Assert.True(eventTriggered);
    }

    [Fact]
    public void AddToCart_ShouldHandleMultipleProducts()
    {
        // Arrange
        var cartService = new CartService();
        var product1 = new Product
        {
            Id = "1",
            Name = "Product 1",
            Price = 10.00m,
            Image = "test1.jpg",
            InStock = true
        };
        var product2 = new Product
        {
            Id = "2",
            Name = "Product 2",
            Price = 20.00m,
            Image = "test2.jpg",
            InStock = true
        };

        // Act
        cartService.AddToCart(product1);
        cartService.AddToCart(product2);
        cartService.AddToCart(product1); // Add product1 again

        // Assert
        Assert.Equal(2, cartService.CartItems.Count);
        
        var item1 = cartService.CartItems.First(i => i.Id == "1");
        var item2 = cartService.CartItems.First(i => i.Id == "2");
        
        Assert.Equal(2, item1.Quantity);
        Assert.Equal(1, item2.Quantity);
    }
}
