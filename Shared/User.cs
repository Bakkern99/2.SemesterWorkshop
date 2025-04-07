namespace Shared;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
    public string Role { get; set; } = "admin";

    public string mobilnummer { get; set; } = "";

    public string Email { get; set; } = "";
}