using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pl.Entities
{
    public class Project
    {
        #region <<ctors>>

        public Project(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
        }

        #endregion

        #region properties

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        #endregion
    }
}
