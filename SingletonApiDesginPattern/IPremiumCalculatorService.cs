namespace SingletonApiDesginPattern
{
    public interface IPremiumCalculatorService
    {
        decimal CalculatePremium(int age, string planType, bool hasPreExistingCondition);
    }
}
