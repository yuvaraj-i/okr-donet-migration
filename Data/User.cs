using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class User
    {
        public User()
        {
            AccomplishmentAccomplishedByNavigations = new HashSet<Accomplishment>();
            AccomplishmentCreatedByNavigations = new HashSet<Accomplishment>();
            ApplicationSettings = new HashSet<ApplicationSetting>();
            CertificateDetails = new HashSet<CertificateDetail>();
            CertificateTypeLogs = new HashSet<CertificateTypeLog>();
            Memberships = new HashSet<Membership>();
            UserMentorMappingMentees = new HashSet<UserMentorMapping>();
            UserMentorMappingMentors = new HashSet<UserMentorMapping>();
            UserSkillMappings = new HashSet<UserSkillMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? AuthUserId { get; set; }
        public string? OldAuthUserId { get; set; }
        public int CompanyId { get; set; }
        public string? Designation { get; set; }
        public string Email { get; set; } = null!;
        public string? OldEmail { get; set; }
        public string Role { get; set; } = null!;
        public bool? CertificateRole { get; set; }
        public bool? OkrRole { get; set; }
        public int? IsDeleted { get; set; }
        public string? Department { get; set; }
        public string? Location { get; set; }
        public string? CognitoUserId { get; set; }

        public virtual ICollection<Accomplishment> AccomplishmentAccomplishedByNavigations { get; set; }
        public virtual ICollection<Accomplishment> AccomplishmentCreatedByNavigations { get; set; }
        public virtual ICollection<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual ICollection<CertificateDetail> CertificateDetails { get; set; }
        public virtual ICollection<CertificateTypeLog> CertificateTypeLogs { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
        public virtual ICollection<UserMentorMapping> UserMentorMappingMentees { get; set; }
        public virtual ICollection<UserMentorMapping> UserMentorMappingMentors { get; set; }
        public virtual ICollection<UserSkillMapping> UserSkillMappings { get; set; }
    }
}
