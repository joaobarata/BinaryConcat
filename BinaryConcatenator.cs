using OutSystems.ExternalLibraries.SDK;

namespace Outsystems.BinaryConcat
{
    public class BinaryConcatenator : IBinaryConcat
    {
        public byte[] BinaryConcat( byte[] BinaryField1, byte[] BinaryField2)
        {
            byte[] binaryResult = new byte[BinaryField1.Length + BinaryField2.Length];
            Buffer.BlockCopy(BinaryField1, 0, binaryResult, 0, BinaryField1.Length);
            Buffer.BlockCopy(BinaryField2, 0, binaryResult, BinaryField1.Length, BinaryField2.Length);

            return binaryResult;
        }
    }
}