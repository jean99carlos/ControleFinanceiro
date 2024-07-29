﻿namespace ControleFinanceiro.Common.Helpers
{
    public interface IPasswordHasher
    {
        string HashPassword(string password, out string salt);
        bool VerifyPassword(string password, string salt, string hash);
    }
}
