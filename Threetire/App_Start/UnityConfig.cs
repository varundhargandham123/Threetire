using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BussinessLogic;
namespace Threetire
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IUserbl, Userbl>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}