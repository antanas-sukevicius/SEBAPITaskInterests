using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SEBInterestRate.Models;
using SEBInterestRate.Data;

namespace SEBInterestRate.Controllers
{
    [Route("api/interests")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly ICustomersRepo _repository;

        public InterestController(ICustomersRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllInterests()
        {
            var interestItems = _repository.GetAppCustomers();

            return Ok(interestItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetInterestById(int id)
        {
            var interestItems = _repository.GetInteresById(id);
            return Ok(interestItems);
        }
    }
}