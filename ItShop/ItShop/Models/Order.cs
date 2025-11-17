using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItShop.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }
		[Required]
		public int UserId { get; set; }
		[Required]
		public DateTime Created { get; set; }
		public bool IsFinaly { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }
		public DateTime CreateDate { get; internal set; }


		[ForeignKey("UserId")]
		public Users User { get; set; }

		
	}
}
