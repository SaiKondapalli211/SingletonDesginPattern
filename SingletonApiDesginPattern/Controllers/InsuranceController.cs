using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SingletonApiDesginPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly IPremiumCalculatorService _premiumCalculatorService;

        public InsuranceController(IPremiumCalculatorService premiumCalculatorService)
        {
            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpGet("calculate-premium")]
        public IActionResult CalculatePremium(int age, string planType, bool hasPreExistingCondition)
        {
            var premium = _premiumCalculatorService.CalculatePremium(age, planType, hasPreExistingCondition);
            return Ok(new { Age = age, PlanType = planType, PremiumAmount = premium });
        }
    }
}
