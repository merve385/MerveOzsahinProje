namespace BauToDoList.Migrations
{
    using BauToDoList.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Threading.Tasks;
    

    internal sealed class Configuration : DbMigrationsConfiguration<BauToDoList.Models.appDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BauToDoList.Models.appDbContext context)
        {
            if (!context.Categories.Any())
            {
                //�lk kullan�mda DB bo� olu�aca��n dan sorun ya�amamak i�in kullan�c� olu�turma i�lemini ve �rnek olsun diye de categories tablosuna veri ekleme �rne�ini bu alan da yap�yoruz. A�a��daki kodlar Categories tablosuna ve ApplicationUser taraf�na ilk kay�tlar�m�z� ekliyoruz.
                context.Categories.Add(new Models.Category() { Name = "Deneme", CreateDate = DateTime.Now, CreatedBy = "username", UpdateDate = DateTime.Now, UpdatedBy = "username" });
                var store = new UserStore<ApplicationUser>(context);
                var manager = new ApplicationUserManager(store);
                var user = new Models.ApplicationUser() { Email = "merve24@gmail.com", UserName = "merve24@gmail.com" };
                Task<Microsoft.AspNet.Identity.IdentityResult> task = Task.Run(() => manager.CreateAsync(user, "Merve24+"));

                // Will block until the task is completed...
                var result = task.Result;


                context.SaveChanges();
            }
        }
    }
}
