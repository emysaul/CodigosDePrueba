namespace TestWebServices.ExtendMethods
{
    public static class StringExtends
    {
        public static bool MatchTest(this string initialText, string experatedText, double tolerance)
        {
            F23.StringSimilarity.JaroWinkler jaroWinkler = new F23.StringSimilarity.JaroWinkler();
            var result = jaroWinkler.Similarity(initialText, experatedText);

            return (result >= tolerance);
        }
    }
}
