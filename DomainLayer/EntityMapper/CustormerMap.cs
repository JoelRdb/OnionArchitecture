using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class CustormerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_customerId"); // clé  primaire
            builder.Property(x => x.Id).ValueGeneratedOnAdd()   // incrémentation à 1
                .HasColumnName("id")
                .HasColumnType("INT");
            builder.Property(x => x.PurchasesProduct)
                .HasColumnName("purchased_product")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
            builder.Property(x => x.PayementType)
                .HasColumnName("payement_type")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();
            builder.Property(x => x.CreatedDate)
                .HasColumnName("created_date")
                .HasColumnType("datetime");
            builder.Property(x => x.ModifiedDate)
                .HasColumnName("modified_date")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
                .HasColumnName("is_active")
                .HasColumnType("bit");

        }
    }
}
