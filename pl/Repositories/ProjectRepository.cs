// -----------------------------------------------------------------------
// <copyright file="ProjectRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Repositories
{
    using System;

    using pl.Interfaces;

    /// <summary>
    /// Responsible for the persisting the project aggregate.
    /// </summary>
    public class ProjectRepository : IProjectRepository
    {
        /// <summary>
        /// Saves the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void Save(Entities.Project project)
        {
            throw new NotImplementedException();
        }
    }
}
