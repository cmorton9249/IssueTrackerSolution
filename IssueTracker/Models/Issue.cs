using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Models
{
	public class Issue
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="Tell us What is wrong")]
		[MaxLength(200)]
		public string Description { get; set; }
		[MaxLength(100000)]
		[DisplayName("Long Description")]
		public string Narrative { get; set; }
		[Required(ErrorMessage = "Who are you?")]
		[DisplayName("Created By")]
		public string AddedBy { get; set; }
		[Required(ErrorMessage = "This is probably suposed to be Open")]
		public string Status { get; set; }
		public bool Closed { get; set; }
	}
}
