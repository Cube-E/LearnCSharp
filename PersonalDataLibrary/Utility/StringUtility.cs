
namespace PersonalDataLibrary.Utility
{
    static class StringUtility
    {
        /// <summary>
        /// Checks name for valid input.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool validateName(string name)
        {
            var value = false;
            value = isNullOrEmpty(name);
            value = ContainsValidCharacters(name);
            return value;
        }

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
