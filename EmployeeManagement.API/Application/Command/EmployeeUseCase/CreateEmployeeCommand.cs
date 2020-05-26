using MediatR;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class CreateEmployeeCommand : IRequest<string>
    {
        public string Name { get; set; }

        public string Location { get; set; }
        public string Desgination { get; set; }
    }
}
