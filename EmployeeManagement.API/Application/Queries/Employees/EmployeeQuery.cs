using EmployeeManagement.Domain.Dtos;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Application.Queries.Employees
{
    public class EmployeeQuery : IEmployeeQuery
    {
        private readonly IRepository<Employee> _repository;

        public EmployeeQuery(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetAll()
        {
            List<EmployeeDto> employees = new List<EmployeeDto>();
            var data = await _repository.GetAllAsync();

            if (data != null)
            {
                foreach (var item in data)
                {
                    employees.Add(new EmployeeDto()
                    {
                        Id = item.Id.ToString(),
                        Name = item.Name,
                        Location = item.Location,
                        Desgination = item.Desgination
                    });
                }
            }

            return employees;
        }
    }
}
