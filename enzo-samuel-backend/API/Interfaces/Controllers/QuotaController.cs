using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using API.Application.Services;
using API.Application.DTOs;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace API.Interfaces.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class QuotaController : ControllerBase
    {
        private readonly IInstallmentService _installmentService;
        private readonly IQuotaService _quotaService;

        public QuotaController(IInstallmentService installmentService, IQuotaService quotaService)
        {
            _installmentService = installmentService;
            _quotaService = quotaService;
        }

        [HttpGet("{quotaId}/installments")]
        public async Task<IActionResult> GetInstallmentsByQuotaId(int quotaId)
        {
            IEnumerable<InstallmentDto> installments = await _installmentService.GetInstallmentsByQuotaIdAsync(quotaId);
            return Ok(installments);
        }

        [HttpPut("installments/{installmentId}/pay")]
        public async Task<IActionResult> MarkInstallmentAsPaid(int installmentId)
        {
            try
            {
                await _installmentService.MarkInstallmentAsPaidAsync(installmentId);
                return Ok(new { Message = "Installment marked as paid." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Installment not found or already paid." });
            }
        }

        [HttpPost("{quotaId}/link-to-client/{clientId}")]
        public async Task<IActionResult> LinkQuotaToClient(int quotaId, int clientId)
        {
            try
            {
                await _quotaService.LinkQuotaToClientAsync(quotaId, clientId);
                return Ok(new { Message = "Quota linked to client successfully." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Quota or client not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpGet("client/{clientId}")]
        public async Task<IActionResult> GetQuotasByClientId(int clientId)
        {
            try
            {
                var quotas = await _quotaService.GetQuotasByClientIdAsync(clientId);
                return Ok(quotas);
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Client not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}