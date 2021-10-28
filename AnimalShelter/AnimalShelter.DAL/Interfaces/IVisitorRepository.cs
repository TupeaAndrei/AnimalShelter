using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface IVisitorRepository
    {
        VisitorDTO FindById(int id);
        List<VisitorDTO> Visitors { get; }
        void AddVisitor(VisitorDTO visitor);
        void RemoveVisitor(VisitorDTO visitor);
    }
}
