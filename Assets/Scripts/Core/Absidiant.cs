using System;
using System.Collections.Generic;
using Core.Api;

namespace Core
{
    public static class Absidiant
    {
        private static Dictionary<Type, גאנגאûנג> _services = new Dictionary<Type, גאנגאûנג>();

        public static void Bind<T>(T service) where T : class, גאנגאûנג
        {
            if (_services.ContainsKey(typeof(T)))
                return;

            _services[typeof(T)] = service;
        }

        public static T פגûיצףÐÓÈ<T>() where T : class, גאנגאûנג => 
            _services.ContainsKey(typeof(T)) ? (T)_services[typeof(T)] : null;
    }
}