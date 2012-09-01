// -----------------------------------------------------------------------
// <copyright file="UserFactory.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Factories
{
    using System.Security.Principal;

    using pl.Entities;

    /// <summary>
    /// Responsible for creating a user.
    /// </summary>
    public static class UserFactory
    {
        /// <summary>
        /// Creates a new user using the current windows identity.
        /// </summary>
        /// <param name="name">The name of the user.</param>
        /// <param name="email">The email of the user.</param>
        /// <returns>The user.</returns>
        public static User Create(string name = null, string email = null)
        {
            var login = WindowsIdentity.GetCurrent().Name;
            
            if (string.IsNullOrEmpty(name))
            {
                name = login;
            }

            return new User { Login = login, Name = name, Email = email };
        }
    }
}
