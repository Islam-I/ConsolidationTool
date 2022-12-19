using System;
using System.Collections.Generic;
using ConsolidationTool.Data.DBModels;
using ConsolidationTool.Data.EntityTypeConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsolidationTool.Data.DatabaseContext
{
    public class ACT_TAX_INVOICE_CONSOLIDATIONContext : IdentityDbContext<UserTbl>
    {
        public ACT_TAX_INVOICE_CONSOLIDATIONContext()
        {
        }

        public ACT_TAX_INVOICE_CONSOLIDATIONContext(DbContextOptions<ACT_TAX_INVOICE_CONSOLIDATIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategorizationDetailsTbl> CategorizationDetailsTbls { get; set; } = null!;
        public virtual DbSet<CategorizationTbl> CategorizationTbls { get; set; } = null!;
        public virtual DbSet<OrganizationTbl> OrganizationTbls { get; set; } = null!;
        public virtual DbSet<PropertyCategorizationTbl> PropertyCategorizationTbls { get; set; } = null!;
        public virtual DbSet<PropertyTbl> PropertyTbls { get; set; } = null!;
        public virtual DbSet<UserTbl> UserTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategorizationDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.CategorizationDetailsId)
                    .HasName("PK_Property_Categorization_Details_Tbl");

                entity.ToTable("Categorization_Details_Tbl");

                entity.Property(e => e.CategorizationDetailsId).HasColumnName("Categorization_Details_ID");

                entity.Property(e => e.CategorizationDetailsArName)
                    .HasMaxLength(300)
                    .HasColumnName("Categorization_Details_Ar_Name");

                entity.Property(e => e.CategorizationDetailsCode)
                    .HasMaxLength(20)
                    .HasColumnName("Categorization_Details_Code");

                entity.Property(e => e.CategorizationDetailsEnName)
                    .HasMaxLength(300)
                    .HasColumnName("Categorization_Details_En_Name");

                entity.Property(e => e.CategorizationId).HasColumnName("Categorization_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_Date");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Categorization)
                    .WithMany(p => p.CategorizationDetailsTbls)
                    .HasForeignKey(d => d.CategorizationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Categorization_Details_Tbl_Categorization_Tbl");
            });

            modelBuilder.Entity<CategorizationTbl>(entity =>
            {
                entity.HasKey(e => e.CategorizationId)
                    .HasName("PK_Property_Categorization_Tbl");

                entity.ToTable("Categorization_Tbl");

                entity.Property(e => e.CategorizationId).HasColumnName("Categorization_ID");

                entity.Property(e => e.CategorizationArName)
                    .HasMaxLength(300)
                    .HasColumnName("Categorization_Ar_name");

                entity.Property(e => e.CategorizationCode)
                    .HasMaxLength(20)
                    .HasColumnName("Categorization_Code");

                entity.Property(e => e.CategorizationEnName)
                    .HasMaxLength(300)
                    .HasColumnName("Categorization_En_Name");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_Date");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<OrganizationTbl>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.ToTable("Organization_Tbl");

                entity.Property(e => e.OrganizationId).HasColumnName("Organization_ID");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Code");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_Date");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LicenseCode)
                    .HasMaxLength(100)
                    .HasColumnName("License_Code");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MultiPropertyYn).HasColumnName("Multi_Property_YN");

                entity.Property(e => e.NoOfProducts).HasColumnName("No_Of_Products");

                entity.Property(e => e.OrganizationArName)
                    .HasMaxLength(100)
                    .HasColumnName("Organization_Ar_Name");

                entity.Property(e => e.OrganizationEnName)
                    .HasMaxLength(100)
                    .HasColumnName("Organization_En_Name");

                entity.Property(e => e.PropertiesNames).HasColumnName("Properties_Names");

                entity.Property(e => e.SysLicenseTypeIds)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_License_Type_IDs");

                entity.Property(e => e.UnlimitedYn).HasColumnName("Unlimited_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PropertyCategorizationTbl>(entity =>
            {
                entity.HasKey(e => e.PropertyCategorizationId)
                    .HasName("PK_Property_Categorization_Tbl_1");

                entity.ToTable("Property_Categorization_Tbl");

                entity.Property(e => e.PropertyCategorizationId).HasColumnName("Property_Categorization_ID");

                entity.Property(e => e.CategorizationDetailsId).HasColumnName("Categorization_Details_ID");

                entity.Property(e => e.CategorizationId).HasColumnName("Categorization_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.HasOne(d => d.CategorizationDetails)
                    .WithMany(p => p.PropertyCategorizationTbls)
                    .HasForeignKey(d => d.CategorizationDetailsId)
                    .HasConstraintName("FK_Property_Categorization_Tbl_Categorization_Details_Tbl");

                entity.HasOne(d => d.Categorization)
                    .WithMany(p => p.PropertyCategorizationTbls)
                    .HasForeignKey(d => d.CategorizationId)
                    .HasConstraintName("FK_Property_Categorization_Tbl_Categorization_Tbl");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyCategorizationTbls)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Property_Categorization_Tbl_Property_Tbl");
            });

            modelBuilder.Entity<PropertyTbl>(entity =>
            {
                entity.HasKey(e => e.PropertyId);

                entity.ToTable("Property_Tbl");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ApiLink)
                    .HasMaxLength(300)
                    .HasColumnName("API_Link");

                entity.Property(e => e.ApiPassword)
                    .HasMaxLength(500)
                    .HasColumnName("API_Password");

                entity.Property(e => e.ApiUsername)
                    .HasMaxLength(100)
                    .HasColumnName("API_Username")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insert_Date");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OrganizationId).HasColumnName("Organization_ID");

                entity.Property(e => e.PropertyArName)
                    .HasMaxLength(100)
                    .HasColumnName("Property_Ar_Name")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PropertyCode)
                    .HasMaxLength(20)
                    .HasColumnName("Property_Code")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.PropertyEnName)
                    .HasMaxLength(100)
                    .HasColumnName("Property_En_Name")
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Update_Date");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });
            modelBuilder.ApplyConfiguration(new BaseEntityTypeConfiguration<PropertyTbl>());
            //modelBuilder.Entity<UserTbl>(entity =>
            //{
            //    entity.HasKey(e => e.UserId);

            //    entity.ToTable("User_Tbl");

            //    entity.Property(e => e.UserId).HasColumnName("User_ID");

            //    entity.Property(e => e.ActiveUserYn).HasColumnName("Active_User_YN");

            //    entity.Property(e => e.DeletedYn)
            //        .HasColumnName("Deleted_YN")
            //        .HasDefaultValueSql("((0))");

            //    entity.Property(e => e.FormId).HasColumnName("Form_ID");

            //    entity.Property(e => e.InsertDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("Insert_Date");

            //    entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

            //    entity.Property(e => e.LastLogin)
            //        .HasColumnType("datetime")
            //        .HasColumnName("Last_Login");

            //    entity.Property(e => e.LastPasswordChanged)
            //        .HasColumnType("datetime")
            //        .HasColumnName("Last_Password_Changed");

            //    entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

            //    entity.Property(e => e.PropertyIdLogChanges).HasColumnName("Property_ID_Log_Changes");

            //    entity.Property(e => e.PropertyIds)
            //        .HasMaxLength(100)
            //        .HasColumnName("Property_IDs");

            //    entity.Property(e => e.UpdateDate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("Update_Date");

            //    entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

            //    entity.Property(e => e.UserArName)
            //        .HasMaxLength(100)
            //        .HasColumnName("User_Ar_Name")
            //        .UseCollation("Arabic_CI_AS");

            //    entity.Property(e => e.UserLoginName)
            //        .HasMaxLength(100)
            //        .HasColumnName("User_Login_Name")
            //        .UseCollation("Arabic_CI_AS");

            //    entity.Property(e => e.UserName)
            //        .HasMaxLength(100)
            //        .HasColumnName("User_Name")
            //        .UseCollation("Arabic_CI_AS");

            //    entity.Property(e => e.UserPassword)
            //        .HasColumnName("User_Password")
            //        .UseCollation("Arabic_CI_AS");
            //});
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
