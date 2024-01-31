﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.User.Udpdate;

public sealed record UserUpdateRequest(Guid Id,
                      string Email, string Name)
                      : IRequest<UserUpdateResponse>;
