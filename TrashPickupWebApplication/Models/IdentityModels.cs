﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrashPickupWebApplication.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccountTypes AccountType { get; set; }
        public int AccountTypeId { get; set; }
        public string StreetAddress { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public ZipCode ZipCode { get; set; }
        public int ZipCodeId { get; set; }


    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<StreetAddress> StreetAddress { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<ZipCode> ZipCode { get; set; }
        public DbSet<Days> Days { get; set; }
        public DbSet<PickupIntervals> PickupIntervals { get; set; }
        public DbSet<RegularServices> RegularServices { get; set; }
        public DbSet<ScheduledServices> ScheduledServices { get; set; }
        public DbSet<AccountTypes> AccountType { get; set; }
        public DbSet<CardTypes> CardType { get; set; }
        public DbSet<PaymentInformation> PaymentInformation { get; set; }

        public ApplicationDbContext()
            //: base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}