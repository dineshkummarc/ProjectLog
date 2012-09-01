// -----------------------------------------------------------------------
// <copyright file="Container.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Helpers
{
    using System;
    using System.Collections.Generic;

    using pl.Exceptions;

    /// <summary>
    /// A very simple lightweight Ioc container. Some terms this class uses:
    ///     Interface:      an interface, ie. IProjectRepository
    ///     Provider:       an type which implements the interface, ie. ProjectRepository
    ///     IsSingleton:    if true, only one instance of the provider is ever created.
    /// This class is used by registering providers to implement interfaces, ie:
    ///     container.Register{IProjectRepository, ProjectRepository}(false);
    /// And then retrieving an object instance for an interface like this:
    ///     container.GetInstance{IProjectRepository}();
    /// </summary>
    public class Container
    {
        #region private

        /// <summary>
        /// Contains an index of registered interfaces and providers.
        /// </summary>
        private readonly Dictionary<string, ContainerEntry> items = 
            new Dictionary<string, ContainerEntry>(StringComparer.InvariantCultureIgnoreCase);

        #endregion

        #region public methods

        /// <summary>
        /// Gets an object which implements the interface.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <returns>An object which implements the interface.</returns>
        public TInterface GetInstance<TInterface>()
            where TInterface : class
        {
            var name = this.GetInterfaceName<TInterface>();

            if (!this.items.ContainsKey(name))
            {
                throw new ContainerException("no such interface has been registered error: {0}", name);
            }

            var entry = this.items[name];

            if (!ReferenceEquals(null, entry.Instance))
            {
                return entry.Instance as TInterface;
            }

            var instance = Activator.CreateInstance(entry.Provider);

            if (entry.IsSingleton)
            {
                entry.Instance = instance;
            }

            return instance as TInterface;
        }

        /// <summary>
        /// Registers the specified interface and provider in the container.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <typeparam name="TProvider">The type of the provider which implements the interface.</typeparam>
        /// <param name="isSingleton">if set to <c>true</c> then a single instance is created.</param>
        public void Register<TInterface, TProvider>(bool isSingleton) 
            where TInterface : class
            where TProvider : TInterface, new()
        {
            var name = this.GetInterfaceName<TInterface>();
           
            if (this.items.ContainsKey(name))
            {
                throw new ContainerException("A provider has already been registered for interface error: {0}", name);
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

        /// <summary>
        /// Gets the name of the interface.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <returns>The name of the interface.</returns>
        private string GetInterfaceName<TInterface>()
        {
            return typeof(TInterface).FullName;
        }

        #endregion

        #region private classes

        /// <summary>
        /// Class ContainerEntry
        /// </summary>
        private class ContainerEntry
        {
            #region private

            /// <summary>
            /// Contains the singleton instance of the provider.
            /// </summary>
            private object instance;

            #endregion

            #region properties

            /// <summary>
            /// Gets or sets the provider. 
            /// The provider is the type of the object which implements an interface.
            /// </summary>            
            public Type Provider { get; set; }

            /// <summary>
            /// Gets or sets a value indicating whether a single instance of the provider should be created.
            /// </summary>            
            public bool IsSingleton { get; set; } 

            /// <summary>
            /// Gets or sets the instance, for singletons only.
            /// </summary>
            public object Instance
            {
                get
                {
                    return this.instance;
                }

                set
                {
                    if (!ReferenceEquals(null, this.instance))
                    {
                        throw new ContainerException("Singleton instance has already been set error");
                    }

                    this.instance = value;
                }
            }

            #endregion
        }

        #endregion
    }
}
