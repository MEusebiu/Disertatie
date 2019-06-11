using DataContext.Context;
using DataContext.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Repository.Abstract;
using Repository.Concrete;
using Services.Abstract;
using Services.Concrete;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using UniLibrary.Models;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;

namespace UniLibrary
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IBookRepository, BookRepository>();
            container.RegisterType<IBookService, BookService>();

            container.RegisterType<IGenreRepository, GenreRepository>();
            container.RegisterType<IGenreService, GenreService>();

            container.RegisterType<IAuthorRepository, AuthorRepository>();
            container.RegisterType<IAuthorService, AuthorService>();

            container.RegisterType<IAuthenticationManager>(
                new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<IUserStore<IdentityUser>, UserStore<IdentityUser>>();
            container.RegisterType<DbContext, UniLibraryDbContext>(new PerThreadLifetimeManager());
            container.RegisterType<IdentityDbContext<ApplicationUser>, ApplicationDbContext>(new PerThreadLifetimeManager());

            container.RegisterType(typeof(IUserStore<>), typeof(UserStore<>));
            var userStore1 = container.Resolve<IUserStore<ApplicationUser>>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}