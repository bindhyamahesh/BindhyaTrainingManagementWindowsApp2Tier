using System.Collections.Generic;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{
    public interface IBatchRepository
    {
        List<Batches> GetBatchDetails();
    }
}