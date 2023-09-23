using FluentValidation;

namespace CleanArchitecture.Application.UseCases.User.Create;

public sealed class UserCreateValidator : AbstractValidator<UserCreateRequest>
{
    public UserCreateValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
    }
}
