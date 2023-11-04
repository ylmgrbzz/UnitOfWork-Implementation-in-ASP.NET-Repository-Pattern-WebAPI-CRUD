using Microsoft.AspNetCore.Mvc;
using Unitofwork.Models;
using static UnitOfWork.Controllers.IUnitOfWork;

namespace UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;

        public CustomerController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await this._unitofWork._customerRepo.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("Getbycode/{id}")]
        public async Task<IActionResult> Getbycode(int id)
        {
            var result = await this._unitofWork._customerRepo.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TblCustomer tblCustomer)
        {
            var result = await this._unitofWork._customerRepo.AddAsync(tblCustomer);
            await this._unitofWork.CompleteAsync();
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(TblCustomer tblCustomer)
        {
            var result = await this._unitofWork._customerRepo.UpdateAsync(tblCustomer);
            await this._unitofWork.CompleteAsync();
            return Ok(result);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._unitofWork._customerRepo.DeleteAsync(id);
            await this._unitofWork.CompleteAsync();
            return Ok(result);
        }
    }
}