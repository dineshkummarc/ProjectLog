// -----------------------------------------------------------------------
// <copyright file="MockUserRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Security.Principal;

    using pl.Entities;
    using pl.Interfaces;

    /// <summary>
    /// A mock user repository to help get kickstarted.
    /// This will be removed later.
    /// </summary>
    public class MockUserRepository : IUserRepository
    {
        /// <summary>
        /// Contains a list of users that have been saved.
        /// </summary>
        private readonly Dictionary<string, User> users = new Dictionary<string, User>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// Loads the user for the current windows identity.
        /// </summary>
        /// <returns>The user if found; otherwise <c>null</c>.</returns>
        public User Load()
        {            
            var login = WindowsIdentity.GetCurrent().Name;
            return this.users.ContainsKey(login) ? this.users[login] : null;
        }

        /// <summary>
        /// Saves the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void Save(User user)
        {
            if (this.users.ContainsKey(user.Login))
            {
                this.users[user.Login] = user;
            }
            else
            {
                this.users.Add(user.Login, user);
            }
        }
    }
}
