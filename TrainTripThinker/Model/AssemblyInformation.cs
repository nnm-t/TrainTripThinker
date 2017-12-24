using System;
using System.Reflection;

namespace TrainTripThinker.Model
{
    public class AssemblyInformation
    {
        private static readonly Assembly assembly;

        static AssemblyInformation()
        {
            assembly = Assembly.GetExecutingAssembly();
        }

        public static Version GetAssemblyVersion()
        {
            return assembly.GetName().Version;
        }

        public static string GetAssemblyTitle()
        {
            return GetCustomAttribute<AssemblyTitleAttribute>(assembly).Title;
        }

        public static string GetAssemblyCompany()
        {
            return GetCustomAttribute<AssemblyCompanyAttribute>(assembly).Company;
        }

        public static string GetAssemblyCopyright()
        {
            return GetCustomAttribute<AssemblyCopyrightAttribute>(assembly).Copyright;
        }

        private static T GetCustomAttribute<T>(Assembly assembly)
            where T : Attribute
        {
            return Attribute.GetCustomAttribute(assembly, typeof(T)) as T;
        }
    }
}