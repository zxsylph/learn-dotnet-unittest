using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
  [TestFixture]
  public class PrimeService_IsPrimeShould
  {
	private PrimeService _primeService;

	[SetUp]
	public void SetUp()
	{
	  _primeService = new PrimeService();
	}

	[TestCase(-1)]
	[TestCase(0)]
	[TestCase(1)]
	public void IsPrime_InputIs1_ReturnFalse(int value)
	{
	  var result = _primeService.IsPrime(value);

	  Assert.IsFalse(result, "1 should not be prime");
	}
  }
}