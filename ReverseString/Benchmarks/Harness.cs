using BenchmarkDotNet.Attributes;
using System;
using System.Linq;
using System.Text;

namespace ReverseString
{
    [InProcess]
    public class Harness
    {
        public string[] Data() => new string[] { "AACOSTA", "aacosta.com.mx" };

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseFor(string text)
        {
            int forward = 0;
            char[] array = new char[text.Length];

            for (int i = text.Length - 1; i >= 0; i--)
            {
                array[forward++] = text[i];
            }

            return new string(array);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseXor(string text)
        {
            char[] array = text.ToCharArray();
            int length = array.Length - 1;

            for (int i = 0; i < length; i++, length--)
            {
                array[i] ^= array[length];
                array[length] ^= array[i];
                array[i] ^= array[length];
            }

            return new string(array);
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseStringBuilder(string text)
        {
            var reverse = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse.Append(text[i]);
            }
            return reverse.ToString();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseWhile(string text)
        {
            int length = text.Length - 1;
            string reverse = string.Empty;

            while (length >= 0)
            {
                reverse += text[length];
                length--;
            }

            return reverse;
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseLINQ(string text)
        {
            return new string(text.Reverse().ToArray());
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public string ReverseRecursive(string text)
        {
            if (text.Length > 0)
            {
                return text[text.Length - 1] + ReverseRecursive(text.Substring(0, text.Length - 1));
            }
            else
            {
                return text;
            }
        }
    }
}
