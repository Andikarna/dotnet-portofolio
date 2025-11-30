using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Hrm
{
    public partial class ConfigApi
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int AppId { get; set; }
        public string Url { get; set; } = null!;
    }
}
