// -----------------------------------------------------------------------
// <copyright file="IProjectRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Interfaces
{
    using pl.Entities;

    /// <summary>
    /// Interface for project repositories.
    /// </summary>
    public interface IProjectRepository
    {
        /// <summary>
        /// Saves the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        void Save(Project project);
    }
}
