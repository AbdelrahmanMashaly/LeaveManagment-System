using LeaveManagment.web.Contracts;
using LeaveManagment.web.Data;
using LeaveManagment.web.Data.Migrations;

namespace LeaveManagment.web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
