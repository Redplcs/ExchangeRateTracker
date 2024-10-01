using ExchangeRateTracker.Crawler.Core.ValueObjects;

namespace ExchangeRateTracker.Crawler.Core.Interfaces;

public interface IExchangeRateProvider
{
	IReadOnlyCollection<ExchangeRate> GetExchangeRates(DateOnly date);
}
