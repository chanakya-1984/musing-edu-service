﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using musingDayCareDomain;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using musingDayCareComman.Interfaces;

namespace musingDayCareCore.InstituteOprations.Command.InstituteCommand
{
    public class UpdateInstituteCommandHandler : IRequestHandler<UpdateInstituteCommand, Institute>
    {

        private readonly IMusingDayCareDbContext _context;
        public UpdateInstituteCommandHandler(IMusingDayCareDbContext context)
        {
            _context = context;
        }

        public async Task<Institute> Handle(UpdateInstituteCommand request, CancellationToken cancellationToken)
        {
            var result = await (from i in _context.InstituteRecord
                          where i.Id == request.Id
                          select i).FirstOrDefaultAsync();
            if (result == null)
                return null;
            result.EstablishedOn = request.EstablishedOn;
            result.Address = request.Address;
            result.AllowedGender = request.AllowedGender;
            result.City = request.City;
            result.ContactNumbers = request.ContactNumbers;
            result.EstablishedOn = request.EstablishedOn;
            result.MailId = request.MailId;
            result.Name = request.Name;
            result.Pin = request.Pin;
            result.Website = request.Website;
            await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
