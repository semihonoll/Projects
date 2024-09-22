namespace _87_API_JWTToken.Models.DTOs
{
    public record UserLoginDTO
    {
        public string UserName { get; init; }
        public string Password { get; init; }
    }
}
