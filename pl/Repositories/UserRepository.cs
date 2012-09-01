// -----------------------------------------------------------------------
// <copyright file="UserRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Repositories
{
    using pl.Entities;
    using pl.Interfaces;

    using System;

    /// <summary>
    /// Responsible for the persistence of user information.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        #region public methods

        /// <summary>
        /// Loads the user for the current windows identity.
        /// </summary>
        /// <returns>The user.</returns>
        public User Load()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
