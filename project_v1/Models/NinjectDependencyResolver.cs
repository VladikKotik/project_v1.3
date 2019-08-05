using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Ninject.Parameters;
using Ninject.Syntax;
using System.Configuration;
using project_v1.Models;


namespace project_v1.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
       

        public IEnumerable<object> GetServices(Type serviceType) {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IAssort>().To<otherAssort>();
            kernel.Bind<ICar>().To<otherCar>();
            kernel.Bind<IConfigurator>().To<Configurator1>();
            //kernel.Bind<ICar>().To<Car>();
            
            // 
           

            //как в примере калькулятор, через интерфейс с конфигуратором
            //мб добавить транспортный один еще
            //создается объект при запросе сам!!


        }
    }
}

