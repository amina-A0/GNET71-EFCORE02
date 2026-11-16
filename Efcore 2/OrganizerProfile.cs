
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Efcore_2  
    {
        public class OrganizerProfile
        {
            public int OrganizerProfileId { get; set; }
            public string Biography { get; set; } = string.Empty;
            public string Website { get; set; } = string.Empty;
            public string Logo { get; set; } = string.Empty;
            public int OrganizerId { get; set; }
            public Organizer Organizer { get; set; } = null!;
        }
    }

