using MediatR;

namespace EmployeeManagement.API.Application.Command.EmployeeUseCase
{
    public class UpdateEmployeeCommand : IRequest<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Location { get; set; }
        public string Desgination { get; set; }
    }
}
