using AnimalShelter.DAL.Entities;
using AnimalShelter.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.DAL.Interfaces
{
    /// <summary>
    /// All entitites will be changed to DTO's after commit is done!
    /// </summary>
    public interface IAdoptionPaperRepository
    {
        AdoptionPaperDTO FindById(int id);
        void AddAdoptionPaper(AdoptionPaperDTO adoptionPaper);
        void RemoveAdoptionPaper(AdoptionPaperDTO adoptionPaper);
        List<AdoptionPaperDTO> AdoptionPaperList { get; }

    }
}
