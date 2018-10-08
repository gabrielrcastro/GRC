using GRC.Data.Context;
using GRC.Domain.Models;
using Microsoft.EntityFrameworkCore;

public class FakeContext : GRCContext
{
    public new virtual DbSet<Product> Products { get; set; }
    public new virtual DbSet<Category> Categories { get; set; }

    public FakeContext() : base(new DbContextOptions<GRCContext>())
    { }

}