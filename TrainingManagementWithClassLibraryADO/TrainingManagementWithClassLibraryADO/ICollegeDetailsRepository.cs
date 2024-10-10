using System.Collections.Generic;
using TrainingManagementDomain;

namespace TrainingManagementWithClassLibraryADO
{
    public interface ICollegeDetailsRepository
    {
        void DeleteCollegeByID(College collegeData);
        void EditCollegeDetailsByID(College collegeData);
        List<College> GetCollegeDetails();
        College GetCollegeDetailsByID(College collegeData);
        void InsertCollegeDetails(College collegeData);
    }
}