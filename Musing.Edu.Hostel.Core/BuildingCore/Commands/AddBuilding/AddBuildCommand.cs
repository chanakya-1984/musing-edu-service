﻿using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding
{
    public class AddBuildCommand: IRequest<BuildingVm>
    {
        public int HostelSetupId { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
    }
}
