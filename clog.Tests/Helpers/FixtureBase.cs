using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pl.Helpers;
using pl.Interfaces;
using pl.Tests.Mocks;

namespace pl.Tests.Helpers
{
    public class FixtureBase
    {
        #region private
 
        private static readonly Container Container = new Container();

        #endregion

        #region <<ctors>>

        static FixtureBase()
        {
        }

        #endregion

        #region protected methods

        public static TInterface GetInstance<TInterface>() where TInterface : class
        { 
            return Container.GetInstance<TInterface>();
        } 

        #endregion

        #region private methods

        private static void SetupContainer()
        {
            Container.Register<IProjectRepository, MockProjectRepository>(false);
        }

        #endregion
    }
}
