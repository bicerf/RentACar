using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor //IInterceptor Autofacden geliyor  o yüzden core için de kuruyoruz autofacleri
    {
        public int Priority { get; set; } //öncelik demek Priority önce loglama sonra cache sonra autorazation falan

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
