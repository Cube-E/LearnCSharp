
namespace PersonalDataLibrary.Utility
{
    static class StringUtility
    {
        /// <summary>
        /// Check if string is null or empty.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isNullOrEmpty(string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Check if string contains valid ascii characters.
        /// TODO: update to take into account unicode/different languages.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool ContainsValidCharacters(string str)
        {
            foreach (char c in str)
            {   
                if(!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
