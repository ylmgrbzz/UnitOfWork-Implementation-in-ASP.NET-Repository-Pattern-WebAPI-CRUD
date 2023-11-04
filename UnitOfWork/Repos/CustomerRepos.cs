using Microsoft.EntityFrameworkCore;
using Unitofwork.Models;
using UnitOfWork.GenericRepos;
using UnitOfWork.Interface;

namespace UnitOfWork.CustomerRepos
{
    public class CustomerRepos : GenericRepository<TblCustomer>, ICustomerRepo
    {
        public override async Task<TblCustomer> AddAsync(TblCustomer entity)
        {
            try
            {
                await DbSet.AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public override async Task<bool> DeleteAsync(int id)
        {
            var existdata = await DbSet.FirstOrDefaultAsync(item => item.Id == id);
            if (existdata != null)
            {
                DbSet.Remove(existdata);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override async Task<IEnumerable<TblCustomer>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public override async Task<TblCustomer> GetByIdAsync(int id)
        {
            return await DbSet.FirstOrDefaultAsync(item => item.Id == id);
        }

        public override async Task<bool> UpdateAsync(TblCustomer obj)
        {
            try
            {
                var existData = await DbSet.FirstOrDefaultAsync(item => item.Id == obj.Id);
                if (existData != null)
                {
                    existData.Name = obj.Name;
                    existData.Phone = obj.Phone;
                    existData.Email = obj.Email;
                    existData.CreditLimit = obj.CreditLimit;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}