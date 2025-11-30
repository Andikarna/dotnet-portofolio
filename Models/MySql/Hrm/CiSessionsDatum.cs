using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class CiSessionsDatum
    {
        public string Id { get; set; } = null!;
        public string IpAddress { get; set; } = null!;
        public uint Timestamp { get; set; }
        public byte[] Data { get; set; } = null!;
    }
}
