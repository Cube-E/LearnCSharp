using System;

namespace PersonalDataLibrary.Utility
{
    public static class StringUtility
    {
        /// <summary>
        /// Check if string is null or empty.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Return true if the string is either empty or false.</returns>
        public static bool isNullOrEmpty(string str) {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Check if string contains valid ascii characters.
        /// TODO: update to take into account unicode/different languages.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Returns true if the string contains invalid characters.</returns>
        public static bool containsInvalidCharacters(string str) {
            foreach (char c in str) {
                if (c != '-' && char.IsLetter(c) == false) {
                    return true;
                }
             }
            return false;
        }
    }
}
