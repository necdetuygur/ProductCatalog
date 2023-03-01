﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Commands.UseCaseCommands.UpdateUseCase
{
    public class UpdateUseCaseCommandRequest : IRequest<UpdateUseCaseCommandResponse>
    {
        public string Id { get; set; }
        public string? Name { get; set; }
    }
}
