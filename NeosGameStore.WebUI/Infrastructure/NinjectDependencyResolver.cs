using Ninject;
using System;
using System.Collections.Generic;
using NeosGameStore.Domain.Entities;
using NeosGameStore.Domain.Abstract;
using System.Web;
using System.Web.Mvc;
using Moq;
using NeosGameStore.Domain.Concrete;

namespace NeosGameStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            this.AddBinding();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBinding()
        {
            kernel.Bind<IGameRepository>().To<EFGameRepository>();
        }
    }
}