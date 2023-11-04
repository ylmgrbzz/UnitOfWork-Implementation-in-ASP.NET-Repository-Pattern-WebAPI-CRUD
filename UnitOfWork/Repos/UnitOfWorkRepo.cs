using Unitofwork.Models;
using UnitOfWork.Controllers;
using UnitOfWork.Interface;
using static UnitOfWork.Controllers.IUnitOfWork;

namespace UnitOfWork.UnitOfWorkRepos
{
    public class UnitOfWorkRepo : IUnitOfWork
    {
        public ICustomerRepo customerrepo { get; private set; }

        private readonly LearnDbContext learnDbContext;

        public UnitOfWorkRepo(LearnDbContext learnDbContext)
        {
            this.learnDbContext = learnDbContext;
            customerrepo = new CustomerRepos(learnDbContext);
        }

        public async Task CompleteAsync()
        {
            await this.learnDbContext.SaveChangesAsync();
        }
    }
}