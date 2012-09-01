using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pl.Entities;

namespace pl.Factories
{
    public static class ProjectFactory
    {
        public static Project Create(string name)
        {
            var project = new Project(name);
            return project;
        }
    }
}
