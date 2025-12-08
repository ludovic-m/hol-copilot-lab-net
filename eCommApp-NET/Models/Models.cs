namespace eCommApp_NET.Models;

public class User
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Address? Address { get; set; }
}

public class Address
{
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
}

public class Review
{
    public string Author { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
}

public class Product
{
    public string? Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public List<Review> Reviews { get; set; } = new();
    public bool InStock { get; set; }
}

public class CartItem
{
    public string? Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public List<Review> Reviews { get; set; } = new();
    public bool InStock { get; set; }
    public int Quantity { get; set; }

    public static CartItem FromProduct(Product product)
    {
        return new CartItem
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            Description = product.Description,
            Image = product.Image,
            Reviews = product.Reviews,
            InStock = product.InStock,
            Quantity = 1
        };
    }
}
