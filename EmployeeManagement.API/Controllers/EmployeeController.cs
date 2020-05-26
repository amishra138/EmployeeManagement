using EmployeeManagement.API.Application.Command.EmployeeUseCase;
using EmployeeManagement.API.Application.Queries.Employees;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Controllers
{
    /// <summary>
    /// Employee crud operation
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IEmployeeQuery _employeeQuery;

        /// <summary>
        /// Initialize
        /// </summary>
        /// <param name="mediator"></param>
        /// <param name="employeeQuery"></param>
        public EmployeeController(IMediator mediator, IEmployeeQuery employeeQuery)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _employeeQuery = employeeQuery ?? throw new ArgumentNullException(nameof(employeeQuery));
        }

        /// <summary>
        /// Get all employee details
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeQuery.GetAll();
            return Ok(result);
        }

        /// <summary>
        /// Create employee
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateEmployeeCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        /// <summary>
        /// Update employee details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]UpdateEmployeeCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        /// <summary>
        /// Delete employee details
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]DeleteEmployeeCommand request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
