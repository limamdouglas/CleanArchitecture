namespace CleanArchitecture.Application.UseCases.User.Create;

public sealed record UserCreateResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}
