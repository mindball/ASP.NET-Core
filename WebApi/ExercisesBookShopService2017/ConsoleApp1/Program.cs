using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            IServiceCollection services = new ServiceCollection();

            services.RegisterAllAssignableType<IAuthorService>(assemblyName);
            Console.WriteLine("Hello World!");
        }

        public static void RegisterAllAssignableType<T>(this IServiceCollection services, string assemblyName)
        {
            var assembly = AppDomain.CurrentDomain.Load(assemblyName);
            var types = assembly.GetTypes().Where(p => typeof(T).IsAssignableFrom(p)).ToArray();

            var addTransientMethod = typeof(ServiceCollectionServiceExtensions).GetMethods().FirstOrDefault(m =>
                m.Name == "AddTransient" &&
                m.IsGenericMethod == true &&
                m.GetGenericArguments().Count() == 2);

            foreach (var type in types)
            {
                if (type.IsInterface)
                    continue;

                var method = addTransientMethod.MakeGenericMethod(new[] { typeof(T), type });
                method.Invoke(services, new[] { services });
            }
        }

    }
}
