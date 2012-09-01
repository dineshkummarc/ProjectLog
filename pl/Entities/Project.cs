// -----------------------------------------------------------------------
// <copyright file="Project.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Entities
{
    using System;

    /// <summary>
    /// Represents a project.
    /// </summary>
    public class Project
    {
        #region <<ctors>>

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="name">The name of the project.</param>
        public Project(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
        }

        #endregion

        #region properties

        /// <summary>
        /// Gets the project Id.
        /// </summary>
        /// <value>The id.</value>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        #endregion
    }
}
