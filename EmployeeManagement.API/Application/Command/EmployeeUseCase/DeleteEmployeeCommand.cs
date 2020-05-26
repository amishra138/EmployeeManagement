using MediatR;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class DeleteEmployeeCommand : IRequest<string>
    {
        public string Id { get; set; }
    }
}
