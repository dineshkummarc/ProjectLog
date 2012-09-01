using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pl.Entities;
using pl.Interfaces;

namespace pl.Tests.Mocks
{
    class MockProjectRepository : IProjectRepository
    {
        #region private

        private readonly List<Project> projects = new List<Project>();

        #endregion

        #region public methods

        public void Save(Project project)
        {
            projects.Add(project);
        }

        public Project Load(Guid id)
        {
            return projects.FirstOrDefault(p => p.Id == id);
        }

        #endregion
    }
}
