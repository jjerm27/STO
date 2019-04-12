using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace STO.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }

        [Display(Name = "ФИО")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Пол")]
        public string Sex { get; set; }
        [Display(Name = "Специализация")]
        public string Specialize { get; set; }
        
        //[Display(Name = "Часы работы")]
        //[Required]
        //public int WorkingTimeId { get; set; }
        //public WorkingTime WorkingTime { get; set; }

        [Required]
        [Display(Name = "Филиал")]
        public int Filial_Id { get; set; }
        public virtual Filial Filial { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения")]
        public System.DateTime BirthDay { get; set; }
        [Required]
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
       
        [Display(Name = "Фото")]
        public string Photo { get; set; }
        [Required]
        [Display(Name = "Дата добавления")]
        [DataType(DataType.Date)]
        public System.DateTime Date_Of_Create { get; set; }

       
        public virtual ICollection<Car> Cars { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
      
        
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("STO_Base", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public virtual DbSet<Filial> Filials { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Box> Boxes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<OrderService> OrderServices { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<StatusOrder> StatusOrders { get; set; }

    }
}