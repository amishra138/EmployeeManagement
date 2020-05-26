using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, string>
    {
        private readonly IRepository<Employee> _repository;

        public CreateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        public async Task<string> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.CreateAsync(new Employee()
                {
                    Name = request.Name,
                    Location = request.Location,
                    Desgination = request.Desgination,
                    CreatedAt = DateTime.UtcNow
                });

                return "Record created successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
