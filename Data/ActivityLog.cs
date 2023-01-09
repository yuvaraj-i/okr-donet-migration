using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class ActivityLog
    {
        public int Id { get; set; }
        /// <summary>
        /// It can be user id, team id or company id.
        /// </summary>
        public int EntityId { get; set; }
        public string EntityType { get; set; } = null!;
        public string ActionItem { get; set; } = null!;
        public DateTime ActionDate { get; set; }
        public int TopicId { get; set; }
        public string TopicType { get; set; } = null!;
        public decimal? Score { get; set; }
        public int? CommentId { get; set; }
        public int? KeyResultId { get; set; }
        /// <summary>
        /// It can be user id for entity type team, and null for user id.
        /// </summary>
        public int? UserId { get; set; }
    }
}
