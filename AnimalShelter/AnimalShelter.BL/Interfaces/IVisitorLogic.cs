using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.BL.Interfaces
{
    public interface IVisitorLogic
    {
        Task AddVisitor(VisitorDTO visitorDTO);
        Task RemoveVisitor(VisitorDTO visitorDTO)
    }
}
