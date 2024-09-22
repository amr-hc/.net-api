using Microsoft.AspNetCore.Mvc;

namespace api.DTO
{
    public class RegisterDTO
    {
        public string username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
