using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

 namespace Efcore_2
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int OrganizerId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
        public OrganizerProfile OrganizerProfile { get; set; } = null!;
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}