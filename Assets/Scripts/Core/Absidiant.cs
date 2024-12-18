using System;
using System.Collections.Generic;
using Core.Api;

namespace Core
{
    public static class Absidiant
    {
        private static Dictionary<Type, ��������> _services = new Dictionary<Type, ��������>();

        public static void Bind<T>(T service) where T : class, ��������
        {
            if (_services.ContainsKey(typeof(T)))
                return;

            _services[typeof(T)] = service;
        }

        public static T ���������<T>() where T : class, �������� => 
            _services.ContainsKey(typeof(T)) ? (T)_services[typeof(T)] : null;
    }
}