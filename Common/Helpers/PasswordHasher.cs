using System.Security.Cryptography;
using System.Text;

namespace ControleFinanceiro.Common.Helpers
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password, out string salt)
        {
            salt = GenerateSalt();
            string passwordWithSalt = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt));
                return Convert.ToBase64String(bytes);
            }
        }

        public bool VerifyPassword(string password, string salt, string hash)
        {
            string passwordWithSalt = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt));
                string hashedPassword = Convert.ToBase64String(bytes);
                return hashedPassword == hash;
            }
        }

        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
    }
}
