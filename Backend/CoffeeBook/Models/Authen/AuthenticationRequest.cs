﻿namespace CoffeeBook.Models.Authen
{
    public record AuthenticationRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthenticationRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}