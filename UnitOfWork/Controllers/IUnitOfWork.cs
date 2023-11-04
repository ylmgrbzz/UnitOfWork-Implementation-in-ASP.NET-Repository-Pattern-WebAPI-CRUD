using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Interface;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IUnitOfWork : ControllerBase
    {
        public interface IUnitofWork
        {
            ICustomerRepo _customerRepo { get; }

            Task CompleteAsync();
        }
    }
}