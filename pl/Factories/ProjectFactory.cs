// -----------------------------------------------------------------------
// <copyright file="ProjectFactory.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------
 
namespace pl.Factories
{
    using pl.Entities;

    /// <summary>
    /// Responsible for creating projects.
    /// </summary>
    public static class ProjectFactory
    {
        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="name">The name of the project.</param>
        /// <returns>The new project.</returns>
        public static Project Create(string name)
        {
            var project = new Project(name);
            return project;
        }
    }
}
