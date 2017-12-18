using System;
using System.Reflection;

namespace TrainTripThinker.Core.Utility
{
    public class VersionManagement
    {
        public static Version GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            return assembly.GetName().Version;
        }
    }
}