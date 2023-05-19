using Core.DAL.Models;
using Core.DALEF.ContextFactory.Seeds;
using Core.DALEF.ContextFactory.Seeds.Dummy;
using IPSTemplate.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.DALEF.ContextFactory;

internal static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SYSetting>().HasData(new SYSettingSeed());
        modelBuilder.Entity<TEEntity>().HasData(new TEEntitySeed());

        if (EnvironmentHelper.IsDevelopment())
        {
            modelBuilder.SeedDummyData();
        }
    }

    private static void SeedDummyData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TEEntity>().HasData(new TEEntityDummy());
    }
}
