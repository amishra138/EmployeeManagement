using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, string>
    {
        private readonly IRepository<Employee> _repository;

        public UpdateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.UpdateAsync(new Employee()
                {
                    Id = Guid.Parse(request.Id),
                    Name = request.Name,
                    Location = request.Location,
                    Desgination = request.Desgination,
                    CreatedAt = DateTime.UtcNow
                });

                return "Record updated successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
