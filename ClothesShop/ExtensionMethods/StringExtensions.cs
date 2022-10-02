namespace ClothesShop.ExtensionMethods
{
    /// <summary>
    /// Definitions of string extension methods
    /// </summary>
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        => (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str)) ? true : false;
    }
}
