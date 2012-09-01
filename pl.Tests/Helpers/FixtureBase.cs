// -----------------------------------------------------------------------
// <copyright file="FixtureBase.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Tests.Helpers
{
    using pl.Helpers;
    using pl.Interfaces;
    using pl.Tests.Mocks;

    /// <summary>
    /// Base class for all fixtures.
    /// </summary>
    public class FixtureBase
    {
        #region private

        /// <summary>
        /// The Ioc container.
        /// </summary>
        private static readonly Container Container = new Container();

        #endregion

        #region <<ctors>>

        /// <summary>
        /// Initializes static members of the <see cref="FixtureBase" /> class.
        /// </summary>
        static FixtureBase()
        {
            SetupContainer();
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Gets an instance of an object from the Ioc container that implements the specified interface.
        /// </summary>
        /// <typeparam name="TInterface">The type of the interface.</typeparam>
        /// <returns>An instance of the interface.</returns>
        public static TInterface GetInstance<TInterface>() where TInterface : class
        { 
            return Container.GetInstance<TInterface>();
        } 

        #endregion

        #region private methods

        /// <summary>
        /// Setups the Ioc container.
        /// </summary>
        private static void SetupContainer()
        {
            Container.Register<IProjectRepository, MockProjectRepository>(false);
        }

        #endregion
    }
}
