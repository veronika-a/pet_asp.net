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
            context.Pets.Add(new Pet { Name = "Terrific Tips", Author="Max",  Link = " /Content/img/c1.jpg", Text = "Important advice every pet owner should know" });
            context.Pets.Add(new Pet { Name = "Paws-On Activities", Author = "Max",  Link = " /Content/img/c2.jpg", Text = "DIY crafts and training tips for animal lovers" });
            context.Pets.Add(new Pet { Name = "Just for Fun", Author = "Max",  Link = " /Content/img/c3.jpg", Text = " IFun quotes, facts, and other pet-related content" });


            base.Seed(context);
        }
    }
}