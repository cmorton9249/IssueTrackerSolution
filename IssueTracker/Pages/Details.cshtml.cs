using System.Threading.Tasks;
using IssueTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Pages
{
	public class DetailsModel : PageModel
    {
        private readonly IssuesDataContext _context;

        public Issue Issue { get; set; }

		public DetailsModel(IssuesDataContext context)
		{
			_context = context;
		}

		public async Task OnGetAsync(int id)
        {
            Issue = await _context.Issues.SingleOrDefaultAsync(i => i.Id == id);
        }

        public async Task<ActionResult> OnPostClose(int id)
		{
			var issue = await _context.Issues.SingleOrDefaultAsync(i => i.Id == id);
			if (issue == null)
			{
				return NotFound();
			}
			issue.Closed = true;
			await _context.SaveChangesAsync();

			return RedirectToPage("Index");
		}
    }
}
