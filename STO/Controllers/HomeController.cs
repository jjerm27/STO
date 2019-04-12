using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using STO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STO.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ApplicationUserManager userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            //// создаем роли
            var role1 = new IdentityRole { Name = "admin" };
            var role2 = new IdentityRole { Name = "user" };
            var role3 = new IdentityRole { Name = "manager" };
            var role4 = new IdentityRole { Name = "master" };
            var role5 = new IdentityRole { Name = "dont_change" };

            //// добавляем роли в бд
            //roleManager.Create(role1);
            //roleManager.Create(role2);
            //roleManager.Create(role3);
            //roleManager.Create(role4);
            //roleManager.Create(role5);

            //Создаем филиал
            //var fil = new Filial {  FilialAdress = "Житомир, Победы, 10" };
            //db.Filials.Add(fil);
            //db.SaveChanges();

            //Создаем box           
            //for (int i = 1; i < 5; i++)
            //{
            //    db.Boxes.Add(new Box { FilialId = 1, BoxNumber = i });
            //}
            //db.SaveChanges();

            // создаем пользователей
            //var admin = new ApplicationUser { Email = "admin@mail.ru", UserName = "admin@mail.ru", Name = "Иванов Иван Иванович", Adress = "B.Berdichevskaya, 1", BirthDay = new DateTime(1989, 2, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380500990653", Sex = "male", Photo = "~/Content/Photos/img1.jpg" };
            //string password = "Qwerty";
            //var result = userManager.Create(admin, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(admin.Id, role1.Name);
            //    userManager.AddToRole(admin.Id, role2.Name);
            //    userManager.AddToRole(admin.Id, role5.Name);
            //}

            //var user = new ApplicationUser { Email = "user1@mail.ru", UserName = "user1@mail.ru", Name = "Егоров Егор Иванович", Adress = "B.Berdichevskaya, 10", BirthDay = new DateTime(1989, 4, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380500770615",  Sex = "male", Photo = "~/Content/Photos/img2.jpg" };

            //result = userManager.Create(user, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, role2.Name);
            //    userManager.AddToRole(user.Id, role5.Name);
            //}


            //user = new ApplicationUser { Email = "user2@mail.ru", UserName = "user2@mail.ru", Name = "Васильева Альбина Петровна", Adress = "B.Berdichevskaya, 22", BirthDay = new DateTime(1980, 4, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380990322524", Sex = "female", Photo = "~/Content/Photos/img3.jpg" };
            //result = userManager.Create(user, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, role2.Name);
            //    userManager.AddToRole(user.Id, role5.Name);
            //}

            //user = new ApplicationUser { Email = "manager1@mail.ru", UserName = "manager1@mail.ru", Name = "Кустов Артем Степанович", Adress = "B.Berdichevskaya, 48", BirthDay = new DateTime(1989, 8, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380992362524", Sex = "male", Photo = "~/Content/Photos/img4.jpg" };

            //result = userManager.Create(user, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, role3.Name);
            //    userManager.AddToRole(user.Id, role5.Name);
            //}

            //user = new ApplicationUser { Email = "master1@mail.ru", UserName = "master1@mail.ru", Name = "Портнов Василий Петрович", Adress = "B.Berdichevskaya, 66", BirthDay = new DateTime(1991, 8, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380504887879", Sex = "male", Photo = "~/Content/Photos/img5.jpg", Specialize = "ремонт ДВС" };

            //result = userManager.Create(user, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, role4.Name);
            //    userManager.AddToRole(user.Id, role5.Name);
            //}

            //user = new ApplicationUser { Email = "master2@mail.ru", UserName = "master2@mail.ru", Name = "Куприн Анатолий Петрович", Adress = "B.Berdichevskaya, 166", BirthDay = new DateTime(1988, 10, 22), Date_Of_Create = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), Filial_Id = 1, IsActive = true, PhoneNumber = "+380501478995", Sex = "male", Specialize = "кузовной ремонт" };

            //result = userManager.Create(user, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(user.Id, role4.Name);
            //    userManager.AddToRole(user.Id, role5.Name);
            //}

            //добавляем машины
            //var uz = db.Users.Where(u => u.Email == "user1@mail.ru").FirstOrDefault();
            //var car = new Car { CarMark = "Chevrolet Aveo", CarNumber = "AA3515CT", UserId = uz.Id };
            //db.Cars.Add(car);
            //car = new Car { CarMark = "BMW x5", CarNumber = "AA8897AM", UserId = uz.Id };
            //db.Cars.Add(car);

            //uz = db.Users.Where(u => u.Email == "user2@mail.ru").FirstOrDefault();
            //car = new Car { CarMark = "Audi", CarNumber = "AH4178TT", UserId = uz.Id };
            //db.Cars.Add(car);
            //db.SaveChangesAsync();

            //Добавляем статусы
            //var status = new Status { StatusName = "Принят" };
            //db.Statuses.Add(status);
            //status = new Status { StatusName = "В работе" };
            //db.Statuses.Add(status);
            //status = new Status { StatusName = "Готово к выдаче" };
            //db.Statuses.Add(status);
            //status = new Status { StatusName = "Завершен" };
            //db.Statuses.Add(status);
            //db.SaveChangesAsync();

            //Добавляем услуги
            //var serv = new Service { ServiceName = "Замена масла", HumanTime = 1, Price = 200.00m };
            //db.Services.Add(serv);
            //serv = new Service { ServiceName = "Ремонт двигателя", HumanTime = 5, Price = 200.00m };
            //db.Services.Add(serv);



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}