
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Efcore_2
    {
        public enum BadgeTier
        {
            Standard,
            VIP
        }

        public class Badge
        {
            public int BadgeId { get; set; }
            public string BadgeNumber { get; set; } = string.Empty;
            public DateTime IssuedDate { get; set; }
            public BadgeTier Tier { get; set; }
            public int AttendeeId { get; set; }
            public Attendee Attendee { get; set; } = null!;
        }
    }

