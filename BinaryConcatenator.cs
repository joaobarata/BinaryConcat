using OutSystems.ExternalLibraries.SDK;

namespace Outsystems.BinaryConcat
{
    public class BinaryConcatenator : IBinaryConcat
    {
        public byte[] BinaryConcat( byte[] BinaryField1, byte[] BinaryField2)
        {

            if(BinaryField1 == null || BinaryField1.Length == 0)
            {
                return BinaryField2 ?? Array.Empty<byte>();
            }
            if (BinaryField2 == null || BinaryField2.Length == 0)
            {
                return BinaryField1;
            }

            byte[] binaryResult = new byte[BinaryField1.Length + BinaryField2.Length];
            Buffer.BlockCopy(BinaryField1, 0, binaryResult, 0, BinaryField1.Length);
            Buffer.BlockCopy(BinaryField2, 0, binaryResult, BinaryField1.Length, BinaryField2.Length);

            return binaryResult;
        }
    }
}