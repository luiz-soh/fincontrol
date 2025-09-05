using Application.Transaction.Boundaries;
using Domain.DTOs.Transaction;
using Domain.Entities.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction([FromBody] CreateTransactionInput input)
        {
            try
            {

                var dto = new TransactionDTO()
                {
                    Name = input.Name,
                    TransactionDate = input.TransactionDate,
                    CategoryId = input.CategoryId,
                    TransactionAmount = input.TransactionAmount
                };

                await _transactionService.CreateTransaction(dto);

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
