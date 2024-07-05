using OutSystems.ExternalLibraries.SDK;

namespace Outsystems.BinaryConcat
{
    [OSInterface(Description = "This extension provides an action that allows to concatenate two Binary Data variables.", IconResourceName = "BinaryConcat.resources.logo.png", Name = "BinaryConcat")]
    public interface IBinaryConcat
    {
        [OSAction(Description = "Concatenate two Binary Data variables.", IconResourceName = "BinaryConcat.resources.logo.png", ReturnName = "BinaryResult")]
        public byte[] BinaryConcat(
            [OSParameter(Description = "First Binary Data field.")]
            byte[] BinaryField1,
            [OSParameter(Description = "Second Binary Data field.")]
            byte[] BinaryField2);
    }
}
