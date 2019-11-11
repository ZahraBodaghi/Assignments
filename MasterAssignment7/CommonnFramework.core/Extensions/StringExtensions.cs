using System;
using System.Collections.Generic;
using System.Text;
/*
 * Zahra Bodaghi
 */
namespace CommonnFramework.Core.Extensions
{
    /// <summary>
    /// Various extension methods for string manipulation.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///  Indicates whether the specified string is null or not 
        /// </summary>
        /// <param name="content"></param>
        /// <returns>true if the content is null or empty and false otherwise</returns>
        public static bool IsNullOrEmpty(this string content)
        {
            return string.IsNullOrEmpty(content);
        }
        /// <summary>
        /// Indicates whether the specified string is null or empty or white spaces
        /// </summary>
        /// <param name="content"></param>
        /// <returns>true if it is null or empty or white space otherwise false</returns>
        public static bool IsNullOrWhiteSpace(this string content)
        {
            return string.IsNullOrWhiteSpace(content);
        }
        /// <summary>
        /// This method retrieve a substring from the current instance of the string.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="numCharacters"></param>
        /// <returns></returns>
        public static string Left(this string content, int numCharacters)
        {
            if(content == null)
            {
                return null;
            }
            if(content.Length < numCharacters)
            {
                return content;
            }
            return content.Substring(startIndex: 0, length: numCharacters);
        }
        /// <summary>
        /// This method retrieve a substring from the current instance of the string.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="numCharacters"></param>
        /// <returns></returns>
        public static string Right(this string content, int numCharacters)
        {
            if(content == null)
            {
                return null;
            }
            if(content.Length < numCharacters)
            {
                return content;
            }
            return content.Substring(startIndex: 0, length: numCharacters);
        }
    }
}
