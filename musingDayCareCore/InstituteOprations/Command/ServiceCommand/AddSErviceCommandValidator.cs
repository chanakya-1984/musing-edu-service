﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace musingDayCareCore.InstituteOprations.Command.ServiceCommand
{
    public class AddServiceCommandValidator: AbstractValidator<AddServiceCommand>
    {
        public AddServiceCommandValidator()
        {
            RuleFor(s => s.ServiceName).NotEmpty().WithMessage("Please provide name for the service");
        }
    }
}
