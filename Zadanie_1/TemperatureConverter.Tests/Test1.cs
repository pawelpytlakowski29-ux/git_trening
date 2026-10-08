using TemperatureConverter.Lib;

namespace TemperatureConverter.Tests;

[TestClass]
public sealed class TemperatureUtilsTests
{
    [TestMethod]
    public void CelsiusToFahrenheitTest_ValidInput_ValidOutput()
    {
        var Input = new List<int> {0, 100, -40};
        var Output = new List<int> {32, 212, -40};

        for (int i = 0; i < Input.Count; i++)
        {
            var InputValue = TemperatureUtils.CelsiusToFahrenheit(Input[i]);
            Assert.AreEqual(Output[i], InputValue);
        }

    }
}
