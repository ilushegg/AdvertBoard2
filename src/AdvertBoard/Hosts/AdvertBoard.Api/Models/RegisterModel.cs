﻿namespace AdvertBoard.Api.Models
{
    public class RegisterModel
    {

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Guid Avatar { get; set; }

    }
}
