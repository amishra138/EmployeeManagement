using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, string>
    {
        private readonly IRepository<Employee> _repository;

        public DeleteEmployeeCommandHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _repository.DeleteAsync(Guid.Parse(request.Id));

                return "Record deleted successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
