using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
	public class Issue
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(200)]
		public string Description { get; set; }
		[MaxLength(100000)]
		public string Narrative { get; set; }
		[Required]
		public string AddedBy { get; set; }
		[Required]
		public string Status { get; set; }
	}
}
