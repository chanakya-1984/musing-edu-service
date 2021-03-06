﻿using System;
using System.Collections.Generic;
using Musing.Edu.Common.Types;

namespace Musing.Edu.Hostel.Domain
{
    public class Bed
    {
        public int Id { get; set; }
        public virtual int RoomId { get; set; }
        public string BedName { get; set; }
        public decimal Charge { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsOccupantStaff { get; set; }
        public ChangeType ChargeOccurencePeriodType { get; set; }
        public int ChargeOccurencePeriod { get; set; }
    }

    public class Room
    {
        public int Id { get; set; }
        public virtual int FloorId { get; set; }
        public string RoomName { get; set; }
        public int NumberOfBeds { get; set; }
        public bool HasEmptyBeds { get; set; }
        public virtual ICollection<Bed> BedCollection { get; set; }
    }

    public class Floor
    {
        public int Id { get; set; }
        public virtual int BuildingId { get; set; }
        public string FloorName { get; set; }
        public bool HasEmptyRooms { get; set; }
        public virtual ICollection<Room> RoomCollection { get; set; }
    }

    public class Building
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
        public virtual ICollection<Floor> FloorCollection { get; set; }
    }

    public class HostelSetup
    {
        public int Id { get; set; }
        public Gender AllowedGender { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
        public ICollection<Building> BuildingCollection { get; set; }
        public virtual ICollection<HostelAndWardenRelations> HostelAndWarden { get; set; }
    }

    

    public class Warden
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string ContactNumber { get; set; }
        public string MailId { get; set; }
        public  DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public Boolean CurrentStatus { get; set; }
        public virtual ICollection<HostelAndWardenRelations> WardenAndHostelRelations { get; set; }
    }

    public class HostelAndWardenRelations
    {
        public int Id { get; set; }
        public int HostelSetupId { get; set; }
        public  int WardenId { get; set; }
        public  DateTime WardenAssignedStartDate { get; set; }
        public  DateTime WardenAssignedEndDate { get; set; }
    }

}
