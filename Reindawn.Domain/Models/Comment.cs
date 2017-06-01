using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid MasterCommentId { get; set; }
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
