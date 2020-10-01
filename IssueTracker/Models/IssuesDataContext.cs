using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Models
{
	public class IssuesDataContext: DbContext
	{
		public IssuesDataContext(DbContextOptions<IssuesDataContext> options): base(options)
		{

		}

		public virtual DbSet<Issue> Issues { get; set; }
	}
}
