using System;
using System.Collections.Generic;
using Core.Api;

namespace Core
{
    public static class Absidiant
    {
        private static Dictionary<Type, exemenation> _services = new Dictionary<Type, exemenation>();

        public static void Bind<T>(T service) where T : class, exemenation
        {
            if (_services.ContainsKey(typeof(T)))
                return;

            _services[typeof(T)] = service;
        }

        public static T facitdetems<T>() where T : class, exemenation => 
            _services.ContainsKey(typeof(T)) ? (T)_services[typeof(T)] : null;
    }
}