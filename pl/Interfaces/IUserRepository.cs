// -----------------------------------------------------------------------
// <copyright file="IUserRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Interfaces
{
    using pl.Entities;

    /// <summary>
    /// Responsible for loading and saving user information.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Loads the user for the current windows identity.
        /// </summary>
        /// <returns>The user.</returns>
        User Load();

        /// <summary>
        /// Saves the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        void Save(User user);
    }
}
