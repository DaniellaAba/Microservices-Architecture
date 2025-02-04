using System;
using Mango.Services.CouponApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponApi.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}
		public DbSet<Coupon> Coupons { get; set; }
	}
}

