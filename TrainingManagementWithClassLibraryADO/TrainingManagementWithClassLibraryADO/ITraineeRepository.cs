using System.Collections.Generic;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{
    public interface ITraineeRepository
    {
        List<Trainees> GetTrainees();
        void InsertTraineeDetails(Trainees trainee);
    }
}