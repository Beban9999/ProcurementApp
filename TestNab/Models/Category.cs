using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TestNab.Models;

public class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ObservableCollectionListSource<ProductCategory> Products { get; } = new();
}