using Microsoft.EntityFrameworkCore;
using sitglerdiet.Controllers;

namespace sitglerdiet;

public class FoodsContext : DbContext
{
    public FoodsContext(DbContextOptions<FoodsContext> options)
        : base(options)
    {
    }

    public DbSet<Food> Foods { get; set; } = null!;
}