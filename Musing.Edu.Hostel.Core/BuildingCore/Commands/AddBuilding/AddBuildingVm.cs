﻿using AutoMapper;
using Musing.Edu.Hostel.Core.Common.AutoMapper;
using Musing.Edu.Hostel.Domain;

namespace Musing.Edu.Hostel.Core.BuildingCore.Commands.AddBuilding
{
    public class BuildingVm : IMapFrom<Building>
    {
        public int Id { get; set; }
        public int HostelSetupId { get; set; }
        public string BuildingName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Building, BuildingVm>();
        }
    }
}
