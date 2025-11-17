using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RobotControlLibrary
{
    public static class PasswordHelper
    {
        /// <summary>
        /// Hash a password using SHA256
        /// </summary>
        /// <param name="password">Plain text password</param>
        /// <returns>Hashed password as byte array</returns>
        public static byte[] HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        /// <summary>
        /// Verify a password against a stored hash
        /// </summary>
        /// <param name="password">Plain text password to verify</param>
        /// <param name="storedHash">Stored hash from database</param>
        /// <returns>True if password matches</returns>
        public static bool VerifyPassword(string password, byte[] storedHash)
        {
            byte[] inputHash = HashPassword(password);

            if (inputHash.Length != storedHash.Length)
                return false;

            for (int i = 0; i < inputHash.Length; i++)
            {
                if (inputHash[i] != storedHash[i])
                    return false;
            }

            return true;
        }
    }
}
