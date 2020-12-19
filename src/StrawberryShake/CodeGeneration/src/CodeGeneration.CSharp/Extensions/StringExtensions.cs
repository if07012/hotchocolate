namespace StrawberryShake.CodeGeneration.CSharp.Extensions
{
    public static class StringExtensions
    {
        public static string ToFieldName(this string rawString)
        {
            return '_' + WithLowerFirstChar(rawString);
        }

        public static string WithLowerFirstChar(this string rawString)
        {
            return char.ToLower(rawString[0]) + rawString.Substring(1);
        }
    }
}
