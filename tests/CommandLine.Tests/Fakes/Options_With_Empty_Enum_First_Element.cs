using CommandLine.Text;
using System.Collections.Generic;

namespace CommandLine.Tests.Fakes
{
    public enum EntityType
    {
        T0,
        T1,
        T2
    }

    public class Options_With_Empty_Enum_First_Element
    {
        [Option('t', "type", HelpText = "My entity")]
        public EntityType BaseEnum { get; set; }

        [Option('v', "value")]
        public int Value { get; set; }
        [Option('d')]
        public double Double { get; set; }
        [Option('b')]
        public bool Bool { get; set; }

        [Usage(ApplicationAlias = "test.exe")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example("1", new Options_With_Empty_Enum_First_Element { BaseEnum = EntityType.T0 });
                yield return new Example("2", new Options_With_Empty_Enum_First_Element { BaseEnum = EntityType.T1 });
                yield return new Example("3", new Options_With_Empty_Enum_First_Element { Value = 1, Double = 0.1, Bool = false });
                yield return new Example("4", new Options_With_Empty_Enum_First_Element { BaseEnum = EntityType.T0, Value = 1, Double = 0.1, Bool = true });
            }
        }
    }
}
