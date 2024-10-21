using CommandLine.Tests.Fakes;
using CommandLine.Text;
using System.Linq;
using Xunit;

namespace CommandLine.Tests.Unit
{
    public class Issue379Tests
    {
        [Fact]
        public void OptionExamples_With_Default_Values_Should_Display_In_Help_Text()
        {
            // Fixture setup
            ParserResult<Options_With_Empty_Enum_First_Element> result =
                new NotParsed<Options_With_Empty_Enum_First_Element>(
                    TypeInfo.Create(typeof(Options_With_Empty_Enum_First_Element)), Enumerable.Empty<Error>());

            // Exercize system
            var text = HelpText.RenderUsageText(result);

            // Verify outcome
            Assert.Contains("test.exe --type T0", text);
            Assert.Contains("test.exe --type T1", text);
            Assert.Contains("test.exe -d 0.1 --type T0 --value 1", text);
            Assert.Contains("test.exe -b -d 0.1 --type T0 --value 1", text);
        }
    }
}
