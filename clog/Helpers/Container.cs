using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.Helpers
{
    public class Container
    {
        #region private

        private class ContainerEntry
        {
            public Type Provider { get; set; }
            public bool IsSingleton { get; set; }
            public object Instance { get; set; }
        }

        private readonly Dictionary<string, ContainerEntry> items = 
            new Dictionary<string, ContainerEntry>(StringComparer.InvariantCultureIgnoreCase);

        #endregion

        #region public methods

        public TInterface GetInstance<TInterface>()
            where TInterface : class
        {
            var name = GetInterfaceName<TInterface>();

            if (!this.items.ContainsKey(name))
            {
                throw new ArgumentException("no such interface has been registered error: {0}", name);
            }

            var entry = this.items[name];

            if (!ReferenceEquals(null, entry))
            {
                return entry.Instance as TInterface;
            }

            var instance = Activator.CreateInstance(entry.Provider);

            if (entry.IsSingleton)
            {
                entry.Instance = instance;
            }

            return entry.Instance as TInterface;
        }

        public void Register<TInterface, TProvider>(bool isSingleton) 
            where TInterface : class
            where TProvider : TInterface, new()
        {
            var name = GetInterfaceName<TInterface>();
           
            if (this.items.ContainsKey(name))
            {
                throw new ArgumentException("A provider has already been registered for interface error: {0}", name);
            }

            var entry = new ContainerEntry
            {
                Provider = typeof(TProvider),
                IsSingleton = isSingleton
            };

            this.items.Add(name, entry);
        }

        #endregion

        #region private methods

        private string GetInterfaceName<TInterface>()
        {
            return typeof(TInterface).FullName;
        }

        #endregion
    }
}
