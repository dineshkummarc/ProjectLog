using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pl.Entities;

namespace pl.Interfaces
{
    public interface IProjectRepository
    {
        void Save(Project project);
    }
}
