using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Shared
{
    public class CustomerViewModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name = "First Name")]
		public string Firstname { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		public string Lastname { get; set; }
		[Required]
		[Display(Name = "Date of Birth")]
		public DateTime? DateOfBirth { get; set; }
		[Required]
		[Display(Name = "PhoneNumber")]
		public string PhoneNumber { get; set; }
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
		[Required]
		[Display(Name = "BankAccountNumber")]
		public string BankAccountNumber { get; set; }
	}
}
