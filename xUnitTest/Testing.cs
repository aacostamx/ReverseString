using ReverseString;
using Xunit;

namespace xUnitTest
{
    public class Testing
    {
        [Fact]
        public void Reverse_Xor()
        {
            var method = new Harness();

            string result = method.ReverseXor("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }

        [Fact]
        public void Reverse_While()
        {
            var method = new Harness();

            string result = method.ReverseWhile("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }

        [Fact]
        public void Reverse_String_Builder()
        {
            var method = new Harness();

            string result = method.ReverseStringBuilder("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }

        [Fact]
        public void Reverse_For()
        {
            var method = new Harness();

            string result = method.ReverseFor("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }

        [Fact]
        public void Reverse_LINQ()
        {
            var method = new Harness();

            string result = method.ReverseLINQ("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }

        [Fact]
        public void Reverse_Recursive()
        {
            var method = new Harness();

            string result = method.ReverseRecursive("xm.moc.atsocaa");

            Assert.Equal("aacosta.com.mx", result);
        }
    }
}
