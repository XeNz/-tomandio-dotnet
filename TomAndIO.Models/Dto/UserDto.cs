namespace TomAndIO.Models.Dto;

public class UserDto
{
    public UserDto(string email, string password)
    {
        Email = email;
        Password = password;
    }
    
    public string Email { get; set; }

    public string Password { get; set; }
}