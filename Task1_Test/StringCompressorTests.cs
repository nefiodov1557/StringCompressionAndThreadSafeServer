using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_Compression;

namespace Task1_Compression.Tests
{
    [TestClass]
    public class StringCompressorTests
    {
        [TestMethod]
        public void Compress_ReturnsCorrectResult()
        {
            string input = "aaabbcc";
            string expected = "a3b2c2";

            string result = StringCompressor.Compress(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Decompress_ReturnsOriginalString()
        {
            string compressed = "a3b2c2";
            string expected = "aaabbcc";

            string result = StringCompressor.Decompress(compressed);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Compress_EmptyString_ReturnsEmpty()
        {
            Assert.AreEqual("", StringCompressor.Compress(""));
        }
    }
}
