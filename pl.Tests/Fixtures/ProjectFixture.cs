// -----------------------------------------------------------------------
// <copyright file="ProjectFixture.cs" company="Humilis">
// David Harper 2012, this is free software.
// </copyright>
// -----------------------------------------------------------------------

namespace pl.Tests.Fixtures
{
    using NUnit.Framework;

    using pl.Factories;
    using pl.Interfaces;
    using pl.Tests.Helpers;

    /// <summary>
    /// Asserts the design and behavior of the Project class.
    /// </summary>
    [TestFixture]
    public class ProjectFixture : FixtureBase
    {
        /// <summary>
        /// Tests the creation and initialization of a new project.
        /// </summary>
        [Test]
        public void TestCanCreateProject()
        {
            var project = ProjectFactory.Create("test_project");
            Assert.IsNotNull(project);
            Assert.IsNotNull(project.Id);
            Assert.AreEqual("test_project", project.Name);
        }

        /// <summary>
        /// Tests that a project is correctly loaded.
        /// </summary>
        [Test]
        public void TestCanLoadProject()
        {
            var project = ProjectFactory.Create("test_project");
            var repository = GetInstance<IProjectRepository>();  
            repository.Save(project);
        }
    }
}
 