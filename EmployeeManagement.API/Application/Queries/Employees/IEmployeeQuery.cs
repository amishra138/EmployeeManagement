using EmployeeManagement.Domain.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Application.Queries.Employees
{
    public interface IEmployeeQuery
    {
        Task<IEnumerable<EmployeeDto>> GetAll();
    }
}
