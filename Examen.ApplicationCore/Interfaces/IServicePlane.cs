using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServicePlane
    {
        public void Add(Plane p);
        public void Update(Plane p);
        public IList<Plane> GetAll();

    }
}
