using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string str, char[] chars)
        {
            if (str is null || chars is null)
            {
                throw new ArgumentNullException($"");
            }

            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                foreach (var ch in chars)
                {
                    if (ch == str[i])
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            if (str is null || chars is null)
            {
                throw new ArgumentNullException($"");
            }

            if (startIndex < 0 || endIndex <= 0 || endIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException($"");
            }

            int result = 0;
            int i = startIndex;

            while (endIndex >= i)
            {
                foreach (var ch in chars)
                {
                    if (ch == str[i])
                    {
                        result++;
                    }
                }

                i++;
            }

            return result;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str is null || chars is null)
            {
                throw new ArgumentNullException($"");
            }

            if (startIndex < 0 || endIndex <= 0 || endIndex >= str.Length || limit <= 0)
            {
                throw new ArgumentOutOfRangeException($"");
            }

            int result = 0;
            int i = startIndex;
            int count = 0;

            do
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[j] == str[i] && count < limit)
                    {
                        result++;
                        count++;
                    }
                }

                i++;
            }
            while (endIndex >= i);

            return result;
        }
    }
}
