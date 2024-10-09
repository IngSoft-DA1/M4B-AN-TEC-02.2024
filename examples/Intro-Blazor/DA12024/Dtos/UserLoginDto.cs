using System.ComponentModel.DataAnnotations;

namespace Dtos;

public class UserLoginDto
{
    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; }

    public UserLoginDto(String email, String password)
    { 
        Email = email;
        Password = password;
    }
}