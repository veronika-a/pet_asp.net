namespace smallpet.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;


    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

    }
    
    public class PetDbInitializer : DropCreateDatabaseAlways<PetContext>
    {
        protected override void Seed(PetContext context)
        {
            context.Pets.Add(new Pet { Name = "Terrific Tips", Link = " ~/Content/img/c1.jpg", Text = "Important advice every pet owner should know" });
            base.Seed(context);
        }
    }
}