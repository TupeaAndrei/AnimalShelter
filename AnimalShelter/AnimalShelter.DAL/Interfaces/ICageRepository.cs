using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    public interface ICageRepository
    {
        CageDTO FindById(int id);
        List<CageDTO> CageList { get; }
        void AddCage(CageDTO cage);
        void RemoveCage(CageDTO cage);
    }
}
