using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.Delete;

public sealed record UserDeleteRequest(Guid Id)
                  : IRequest<UserDeleteResponse>;
