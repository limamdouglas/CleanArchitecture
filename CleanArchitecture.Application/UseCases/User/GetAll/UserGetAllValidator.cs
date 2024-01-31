using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.GetAll;

public class UserGetAllValidator : AbstractValidator<UserGetAllRequest>
{
    public UserGetAllValidator()
    {
        
    }
}
