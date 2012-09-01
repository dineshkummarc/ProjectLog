// ----------------------------------------------------------------------- 
// <copyright file="MockProjectRepository.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using pl.Entities;
    using pl.Interfaces;

    /// <summary>
    /// A mock ProjectRepository used for testing.
    /// </summary>
    public class MockProjectRepository : IProjectRepository 
    {
        #region private

        /// <summary>
        /// Contains a list of saved projects.
        /// </summary>
        private readonly List<Project> projects = new List<Project>();

        #endregion

        #region public methods

        /// <summary>
        /// Saves the specified project.
        /// </summary>
        /// <param name="project">The project.</param>
        public void Save(Project project)
        {
            this.projects.Add(project);
        }

        /// <summary>
        /// Loads the project with the specified id.
        /// </summary>
        /// <param name="id">The project id.</param>
        /// <returns>The project with the specified id; otherwise <c>null</c>.</returns>
        public Project Load(Guid id)
        {
            return this.projects.FirstOrDefault(p => p.Id == id);
        }

        #endregion
    }
}
