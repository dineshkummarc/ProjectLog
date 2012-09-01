// ----------------------------------------------------------------------- 
// <copyright file="UserFixture.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Tests.Fixtures
{
    using System.Security.Principal;

    using NUnit.Framework;

    using pl.Factories;

    /// <summary>
    /// Asserts the design and behavior of the user class.
    /// </summary>
    [TestFixture]
    public class UserFixture
    {
        /// <summary>
        /// Tests user creation and initialization.
        /// </summary>
        [Test]
        public void TestCanCreateUser()
        {
            var user = UserFactory.Create();
            var login = WindowsIdentity.GetCurrent().Name;

            Assert.IsNotNull(user);
            Assert.AreEqual(user.Login, login);
            Assert.AreEqual(user.Name, login);
            Assert.IsNull(user.Email);

            user = UserFactory.Create("David Harper", "daharper@hotmail.com");
            
            Assert.IsNotNull(user);
            Assert.AreEqual(user.Login, login);
            Assert.AreEqual(user.Name, "David Harper");
            Assert.AreEqual(user.Email, "daharper@hotmail.com");
        }
    }
}
