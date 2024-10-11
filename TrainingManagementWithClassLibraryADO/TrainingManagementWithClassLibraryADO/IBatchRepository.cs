using System.Collections.Generic;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{
    public interface IBatchRepository
    {
        List<Batches> GetBatchDetails(Batches batchs, string option);
        void InsertEditDeleteBatchDetails(Batches batches,string option);
    }
}