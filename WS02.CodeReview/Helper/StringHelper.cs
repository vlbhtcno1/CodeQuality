using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS02.CodeReview.Helper
{
    public class StringHelper
    {
        /// <summary>
        /// Get full gender by given first character.
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public string GetFullGender(string gender)
        {
            if (gender == "m")
            {
                return "Male";
            }

            if (gender == "f")
            {
                return "Female";
            }

            if (gender == "l")
            {
                return "LGBT";
            }

            return "Other";
        }

        /// <summary>
        /// Check two password is matched or not.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns></returns>
        public bool CheckTwoPasswordIsMatched(string password, string confirmPassword)
        {
            bool isMatched = false;
            if (password == confirmPassword)
            {
                isMatched = true;
            }

            return isMatched;
        }

    }
}