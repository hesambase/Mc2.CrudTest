using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace Mc2.CrudTest.Infrastructure.Models.Customer
{
	[Table("Customer", Schema = "dbo")]
	public class Customer
    {
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string BankAccountNumber { get; set; }
	}
	
}
