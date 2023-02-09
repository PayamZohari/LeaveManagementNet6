using LeaveManagement.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.Services
{
    public class LeaveTypeRepository : GenericRepository<LeaveType> , ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
