// -----------------------------------------------------------------------
// <copyright file="User.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Entities
{
    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User
    {
        #region properties

        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary> 
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }         

        #endregion
    }
}
 