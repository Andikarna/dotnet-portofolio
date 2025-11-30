using System;
using System.Collections.Generic;

namespace AdidataDbContext.Models.MySql.Auth
{
    public partial class FeatureType
    {
        public ulong id { get; set; }
        public ulong menu_id { get; set; }
        public string feature_name { get; set; } = null!;
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? deleted_date { get; set; }
    }
}
