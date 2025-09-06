using Application.Transaction.Boundaries;
using Domain.DTOs.Transaction;
using Domain.Entities.Transaction;
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

        [HttpPut]
        public async Task<IActionResult> UpdateTransaction([FromBody] UpdateTransactionInput input)
        {
            try
            {
                var dto = new TransactionDTO()
                {
                    Id = input.Id,
                    Name = input.Name,
                    TransactionDate = input.TransactionDate,
                    CategoryId = input.CategoryId,
                    TransactionAmount = input.TransactionAmount
                };

                await _transactionService.UpdateTransaction(dto);

                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionById([FromRoute] int id)
        {
            try
            {
                var dto = await _transactionService.GetTransactionById(id);

                var response = new GetTransactionOutput(dto);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("list")]
        public async Task<IActionResult> ListTransactions()
        {
            var dto = await _transactionService.ListTransactions();

            var response = dto.Select(x => new TransactionOutput(x)).ToList();

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            try
            {
                await _transactionService.DeleteTransactionById(id);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
