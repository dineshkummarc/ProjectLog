using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using pl.Factories;
using pl.Entities;
using pl.Repositories;
using pl.Tests.Helpers;
using pl.Interfaces;

namespace pl.Tests.Fixtures
{
    [TestFixture]
    public class ProjectFixture : FixtureBase
    {
        [Test]
        public void TestCanCreateProject()
        {
            var project = ProjectFactory.Create("test_project");
            Assert.IsNotNull(project);
            Assert.IsNotNull(project.Id);
            Assert.IsNullOrEmpty(project.Name);
        }

        [Test]
        public void TestCanLoadProject()
        {
            var project = ProjectFactory.Create("test_project");
            var repository = GetInstance<IProjectRepository>();  
            repository.Save(project);


        }
    }
}
 