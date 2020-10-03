using GrandBazar.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GrandBazar.Models
{
    public class ChatMessage
    {
        [Key]
        public string Id { get; set; } = new Guid().ToString();

        [Required]
        [MaxLength(AttributesConstraints.ContentMaxLength)]
        public string Content { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string SenderName { get; set; }

        [Required]
        [MaxLength(AttributesConstraints.UserNameMaxLength)]
        public string ReceiverName { get; set; }
    }
}
