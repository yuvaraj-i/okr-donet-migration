using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string TopicType { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; } = null!;
    }
}
