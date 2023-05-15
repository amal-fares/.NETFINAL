using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServicePlane : IServicePlane { 

    //Partie 6.1
    //private IGenericRepository<Plane> genericRepository;

    //public ServicePlane(IGenericRepository<Plane> genericRepository)
    //{
    //    this.genericRepository = genericRepository;
    //}

    //public void Add(Plane p)
    //{ 
    //   genericRepository.Add(p);    
    //}

    //public void Update(Plane p)
    //{
    //    genericRepository.Update(p);
    //}

    //public IList<Plane> GetAll()
    //{
    //    return genericRepository.GetAll().ToList();
    //}

    //Partie 6.2
    private IUnitOfWork unitOfWork;
    public ServicePlane(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
    }

    public void Add(Plane p)
    {
        // genericRepository.Add(p);
        unitOfWork.Repository<Plane>().Add(p);
    }

    public void Update(Plane p)
    {
        // genericRepository.Update(p);
        unitOfWork.Repository<Plane>().Update(p);
    }

    public IList<Plane> GetAll()
    {
        //return genericRepository.GetAll().ToList();
        return unitOfWork.Repository<Plane>().GetAll().ToList();
    }
}
}
