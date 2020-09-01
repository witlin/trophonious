using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace trophonious.model
{
    public partial class DaoContext : DbContext
    {
        public DaoContext()
        {
        }

        public DaoContext(DbContextOptions<DaoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BackupSuppliersMd> BackupSuppliersMd { get; set; }
        public virtual DbSet<BomsectionCategoriesMd> BomsectionCategoriesMd { get; set; }
        public virtual DbSet<BuildingAreasMd> BuildingAreasMd { get; set; }
        public virtual DbSet<CutsheetsMd> CutsheetsMd { get; set; }
        public virtual DbSet<DeviceCategoriesMd> DeviceCategoriesMd { get; set; }
        public virtual DbSet<DeviceSubcategoriesMd> DeviceSubcategoriesMd { get; set; }
        public virtual DbSet<DeviceTypesMd> DeviceTypesMd { get; set; }
        public virtual DbSet<DocumentTemplatesMd> DocumentTemplatesMd { get; set; }
        public virtual DbSet<EngineeringUnitTypesMd> EngineeringUnitTypesMd { get; set; }
        public virtual DbSet<EquipmentCategoriesMd> EquipmentCategoriesMd { get; set; }
        public virtual DbSet<EquipmentSubcategoriesMd> EquipmentSubcategoriesMd { get; set; }
        public virtual DbSet<EquipmentTypesMd> EquipmentTypesMd { get; set; }
        public virtual DbSet<FlowMeterTypesMd> FlowMeterTypesMd { get; set; }
        public virtual DbSet<ManufacturersMd> ManufacturersMd { get; set; }
        public virtual DbSet<NetworkTypeMd> NetworkTypeMd { get; set; }
        public virtual DbSet<PanelBomMd> PanelBomMd { get; set; }
        public virtual DbSet<PanelCategoriesMd> PanelCategoriesMd { get; set; }
        public virtual DbSet<PanelDwgindexMd> PanelDwgindexMd { get; set; }
        public virtual DbSet<PanelSubcategoriesMd> PanelSubcategoriesMd { get; set; }
        public virtual DbSet<PanelVendorsMd> PanelVendorsMd { get; set; }
        public virtual DbSet<PanelsMd> PanelsMd { get; set; }
        public virtual DbSet<PartCategoriesMd> PartCategoriesMd { get; set; }
        public virtual DbSet<PartSubcategoriesMd> PartSubcategoriesMd { get; set; }
        public virtual DbSet<PartsMd> PartsMd { get; set; }
        public virtual DbSet<PipeMaterialTypesMd> PipeMaterialTypesMd { get; set; }
        public virtual DbSet<ProjectsMd> ProjectsMd { get; set; }
        public virtual DbSet<SubmittalSectionCategoriesMd> SubmittalSectionCategoriesMd { get; set; }
        public virtual DbSet<SubmittalSectionsMd> SubmittalSectionsMd { get; set; }
        public virtual DbSet<SuppliersMd> SuppliersMd { get; set; }
        public virtual DbSet<ValveConnectionTypesMd> ValveConnectionTypesMd { get; set; }
        public virtual DbSet<ValveTypesMd> ValveTypesMd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=AWS;User Id=sa; Password=Password_01");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BackupSuppliersMd>(entity =>
            {
                entity.HasKey(e => e.BackupSupplierId)
                    .HasName("pk_BackupSupplier_Id");

                entity.ToTable("BackupSuppliers_md");

                entity.HasIndex(e => e.BackupSupplierName)
                    .HasName("uk_BackupSupplierName")
                    .IsUnique();

                entity.Property(e => e.BackupSupplierId).HasColumnName("BackupSupplier_Id");

                entity.Property(e => e.BackupSupplierName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BomsectionCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.BomsectionCategoryId)
                    .HasName("pk_BOMSectionCategory_Id");

                entity.ToTable("BOMSectionCategories_md");

                entity.HasIndex(e => e.BomsectionCategoryName)
                    .HasName("uk_BOMSectionCategoryName")
                    .IsUnique();

                entity.Property(e => e.BomsectionCategoryId).HasColumnName("BOMSectionCategory_Id");

                entity.Property(e => e.BomsectionCategoryName)
                    .IsRequired()
                    .HasColumnName("BOMSectionCategoryName")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BuildingAreasMd>(entity =>
            {
                entity.HasKey(e => e.BuildingAreaId)
                    .HasName("pk_BuildingArea_Id");

                entity.ToTable("BuildingAreas_md");

                entity.Property(e => e.BuildingAreaId).HasColumnName("BuildingArea_Id");

                entity.Property(e => e.AreaDescription).HasMaxLength(256);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Cadname)
                    .IsRequired()
                    .HasColumnName("CADName")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CutsheetsMd>(entity =>
            {
                entity.HasKey(e => e.CutsheetId)
                    .HasName("pk_Cutsheet_Id");

                entity.ToTable("Cutsheets_md");

                entity.HasIndex(e => e.FilePath)
                    .HasName("uk_FilePath")
                    .IsUnique();

                entity.Property(e => e.CutsheetId).HasColumnName("Cutsheet_Id");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<DeviceCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.DeviceCategoryId)
                    .HasName("pk_DeviceCategory_Id");

                entity.ToTable("DeviceCategories_md");

                entity.HasIndex(e => e.DeviceCategory)
                    .HasName("uk_DeviceCategory")
                    .IsUnique();

                entity.Property(e => e.DeviceCategoryId).HasColumnName("DeviceCategory_Id");

                entity.Property(e => e.DeviceCategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<DeviceSubcategoriesMd>(entity =>
            {
                entity.HasKey(e => e.DeviceSubcategoryId)
                    .HasName("pk_DeviceSubcategory_Id");

                entity.ToTable("DeviceSubcategories_md");

                entity.HasIndex(e => e.DeviceSubcategory)
                    .HasName("uk_DeviceSubcategory")
                    .IsUnique();

                entity.Property(e => e.DeviceSubcategoryId).HasColumnName("DeviceSubcategory_Id");

                entity.Property(e => e.DeviceSubcategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<DeviceTypesMd>(entity =>
            {
                entity.HasKey(e => e.DeviceTypeId)
                    .HasName("pk_DeviceType_Id");

                entity.ToTable("DeviceTypes_md");

                entity.HasIndex(e => e.TypeName)
                    .HasName("uk_TypeName")
                    .IsUnique();

                entity.Property(e => e.DeviceTypeId).HasColumnName("DeviceType_Id");

                entity.Property(e => e.DeviceCategoryId).HasColumnName("DeviceCategory_Id");

                entity.Property(e => e.DeviceDescription).HasMaxLength(512);

                entity.Property(e => e.DeviceSubcategoryId).HasColumnName("DeviceSubcategory_Id");

                entity.Property(e => e.NetworkTypeId).HasColumnName("NetworkType_Id");

                entity.Property(e => e.PartId).HasColumnName("Part_Id");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.DeviceCategory)
                    .WithMany(p => p.DeviceTypesMd)
                    .HasForeignKey(d => d.DeviceCategoryId)
                    .HasConstraintName("fk_DeviceCategory_Id");

                entity.HasOne(d => d.DeviceSubcategory)
                    .WithMany(p => p.DeviceTypesMd)
                    .HasForeignKey(d => d.DeviceSubcategoryId)
                    .HasConstraintName("fk_DeviceSubcategory_Id");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.DeviceTypesMd)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("fk_DevicePart_Id");
            });

            modelBuilder.Entity<DocumentTemplatesMd>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("pk_Template_Id");

                entity.ToTable("DocumentTemplates_md");

                entity.HasIndex(e => e.FilePath)
                    .HasName("uk_TemplateFilePath")
                    .IsUnique();

                entity.HasIndex(e => e.LastModified)
                    .HasName("uk_LastModified")
                    .IsUnique();

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.LastModified).HasColumnType("datetimeoffset(0)");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<EngineeringUnitTypesMd>(entity =>
            {
                entity.HasKey(e => e.UnitTypeId)
                    .HasName("pk_UnitType_Id");

                entity.ToTable("EngineeringUnitTypes_md");

                entity.HasIndex(e => e.Unit)
                    .HasName("uk_Unit")
                    .IsUnique();

                entity.HasIndex(e => e.UnitName)
                    .HasName("uk_UnitName")
                    .IsUnique();

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitType_Id");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<EquipmentCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.EquipmentCategoryId)
                    .HasName("pk_EquipmentCategory_Id");

                entity.ToTable("EquipmentCategories_md");

                entity.HasIndex(e => e.EquipmentCategory)
                    .HasName("uk_EquipmentCategory")
                    .IsUnique();

                entity.Property(e => e.EquipmentCategoryId).HasColumnName("EquipmentCategory_Id");

                entity.Property(e => e.EquipmentCategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<EquipmentSubcategoriesMd>(entity =>
            {
                entity.HasKey(e => e.EquipmentSubcategoryId)
                    .HasName("pk_EquipmentSubcategory_Id");

                entity.ToTable("EquipmentSubcategories_md");

                entity.HasIndex(e => e.EquipmentSubcategory)
                    .HasName("uk_EquipmentSubcategory")
                    .IsUnique();

                entity.Property(e => e.EquipmentSubcategoryId).HasColumnName("EquipmentSubcategory_Id");

                entity.Property(e => e.EquipmentSubcategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<EquipmentTypesMd>(entity =>
            {
                entity.HasKey(e => e.EquipmentTypeId)
                    .HasName("pk_EquipmentType_Id");

                entity.ToTable("EquipmentTypes_md");

                entity.HasIndex(e => e.EquipmentName)
                    .HasName("uk_EquipmentName")
                    .IsUnique();

                entity.Property(e => e.EquipmentTypeId).HasColumnName("EquipmentType_Id");

                entity.Property(e => e.EquipmentCategoryId).HasColumnName("EquipmentCategory_Id");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.EquipmentSubcategoryId).HasColumnName("EquipmentSubcategory_Id");

                entity.HasOne(d => d.EquipmentCategory)
                    .WithMany(p => p.EquipmentTypesMd)
                    .HasForeignKey(d => d.EquipmentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EquipmentCategory_Id");

                entity.HasOne(d => d.EquipmentSubcategory)
                    .WithMany(p => p.EquipmentTypesMd)
                    .HasForeignKey(d => d.EquipmentSubcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EquipmentSubcategory_Id");
            });

            modelBuilder.Entity<FlowMeterTypesMd>(entity =>
            {
                entity.HasKey(e => e.FlowMeterTypeId)
                    .HasName("pk_FlowMeterType_Id");

                entity.ToTable("FlowMeterTypes_md");

                entity.Property(e => e.FlowMeterTypeId).HasColumnName("FlowMeterType_Id");

                entity.Property(e => e.MeterRange)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.MeterService)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PartId).HasColumnName("Part_Id");

                entity.Property(e => e.PipeMaterialId).HasColumnName("PipeMaterial_Id");

                entity.Property(e => e.PipeSizeInches).HasColumnName("PipeSize_Inches");

                entity.Property(e => e.UnitId).HasColumnName("Unit_Id");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.FlowMeterTypesMd)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("fk_MeterPart_Id");

                entity.HasOne(d => d.PipeMaterial)
                    .WithMany(p => p.FlowMeterTypesMd)
                    .HasForeignKey(d => d.PipeMaterialId)
                    .HasConstraintName("fk_PipeMaterial_Id");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.FlowMeterTypesMd)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_Unit_Id");
            });

            modelBuilder.Entity<ManufacturersMd>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("pk_Manufacturer_Id");

                entity.ToTable("Manufacturers_md");

                entity.HasIndex(e => e.ManufacturerName)
                    .HasName("uk_ManufacturerName")
                    .IsUnique();

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.Property(e => e.ManufacturerName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<NetworkTypeMd>(entity =>
            {
                entity.HasKey(e => e.NetworkTypeId)
                    .HasName("pk_NetworkType_Id");

                entity.ToTable("NetworkType_md");

                entity.Property(e => e.NetworkTypeId).HasColumnName("NetworkType_Id");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PanelBomMd>(entity =>
            {
                entity.HasKey(e => e.PanelBomId)
                    .HasName("pk_PanelBOM_Id");

                entity.ToTable("PanelBOM_md");

                entity.Property(e => e.PanelBomId).HasColumnName("PanelBOM_Id");

                entity.Property(e => e.PartId).HasColumnName("Part_Id");

                entity.Property(e => e.ProvidedBy)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.PanelBomMd)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("fk_PanelPart_Id");
            });

            modelBuilder.Entity<PanelCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.PanelCategoryId)
                    .HasName("pk_PanelCategory_Id");

                entity.ToTable("PanelCategories_md");

                entity.HasIndex(e => e.PanelCategory)
                    .HasName("uk_PanelCategory")
                    .IsUnique();

                entity.Property(e => e.PanelCategoryId).HasColumnName("PanelCategory_Id");

                entity.Property(e => e.PanelCategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PanelDwgindexMd>(entity =>
            {
                entity.HasKey(e => e.PanelIndexId)
                    .HasName("pk_PanelIndex_Id");

                entity.ToTable("PanelDWGIndex_md");

                entity.HasIndex(e => e.SheetNumber)
                    .HasName("uk_SheetNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SheetTitle)
                    .HasName("uk_SheetTitle")
                    .IsUnique();

                entity.Property(e => e.PanelIndexId).HasColumnName("PanelIndex_Id");

                entity.Property(e => e.SheetTitle)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<PanelSubcategoriesMd>(entity =>
            {
                entity.HasKey(e => e.PanelSubcategoryId)
                    .HasName("pk_PanelSubcategory_Id");

                entity.ToTable("PanelSubcategories_md");

                entity.HasIndex(e => e.PanelSubcategory)
                    .HasName("uk_PanelSubcategory")
                    .IsUnique();

                entity.Property(e => e.PanelSubcategoryId).HasColumnName("PanelSubcategory_Id");

                entity.Property(e => e.PanelSubcategory)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PanelVendorsMd>(entity =>
            {
                entity.HasKey(e => e.PanelVendorId)
                    .HasName("pk_PanelVendor_Id");

                entity.ToTable("PanelVendors_md");

                entity.HasIndex(e => e.PanelVendorName)
                    .HasName("uk_PanelVendorName")
                    .IsUnique();

                entity.Property(e => e.PanelVendorId).HasColumnName("PanelVendor_Id");

                entity.Property(e => e.PanelVendorName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PanelsMd>(entity =>
            {
                entity.HasKey(e => e.PanelId)
                    .HasName("pk_Panel_Id");

                entity.ToTable("Panels_md");

                entity.HasIndex(e => e.DwgfilePath)
                    .HasName("uk_DWGFilePath")
                    .IsUnique();

                entity.HasIndex(e => e.ImageFolderPath)
                    .HasName("uk_ImageFolderPath")
                    .IsUnique();

                entity.HasIndex(e => e.LastModified)
                    .HasName("uk_PanelLastModified")
                    .IsUnique();

                entity.HasIndex(e => e.PanelNumber)
                    .HasName("uk_PanelNumber")
                    .IsUnique();

                entity.HasIndex(e => e.PdffilePath)
                    .HasName("uk_PDFFilePath")
                    .IsUnique();

                entity.HasIndex(e => e.ProductRevisionNumber)
                    .HasName("uk_ProductRevisionNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SheetMgrFilePath)
                    .HasName("uk_SheetMgrFilePath")
                    .IsUnique();

                entity.Property(e => e.PanelId).HasColumnName("Panel_Id");

                entity.Property(e => e.DwgfilePath)
                    .IsRequired()
                    .HasColumnName("DWGFilePath")
                    .HasMaxLength(128);

                entity.Property(e => e.ImageFolderPath)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastModified).HasColumnType("datetimeoffset(0)");

                entity.Property(e => e.LastModifiedBy)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PanelBomId).HasColumnName("PanelBOM_Id");

                entity.Property(e => e.PanelCategoryId).HasColumnName("PanelCategory_Id");

                entity.Property(e => e.PanelDescription)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.PanelDwgindexId).HasColumnName("PanelDWGIndex_Id");

                entity.Property(e => e.PanelNumber)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PanelSubcategoryId).HasColumnName("PanelSubcategory_Id");

                entity.Property(e => e.PdffilePath)
                    .IsRequired()
                    .HasColumnName("PDFFilePath")
                    .HasMaxLength(128);

                entity.Property(e => e.ProductRevisionNumber).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.SheetMgrFilePath)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.PanelBom)
                    .WithMany(p => p.PanelsMd)
                    .HasForeignKey(d => d.PanelBomId)
                    .HasConstraintName("fk_PanelBOM_Id");

                entity.HasOne(d => d.PanelCategory)
                    .WithMany(p => p.PanelsMd)
                    .HasForeignKey(d => d.PanelCategoryId)
                    .HasConstraintName("fk_PanelCategory_Id");

                entity.HasOne(d => d.PanelDwgindex)
                    .WithMany(p => p.PanelsMd)
                    .HasForeignKey(d => d.PanelDwgindexId)
                    .HasConstraintName("fk_PanelDWGIndex_Id");

                entity.HasOne(d => d.PanelSubcategory)
                    .WithMany(p => p.PanelsMd)
                    .HasForeignKey(d => d.PanelSubcategoryId)
                    .HasConstraintName("fk_PanelSubcategory_Id");
            });

            modelBuilder.Entity<PartCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.PartCategoryId)
                    .HasName("pk_PartCategory_Id");

                entity.ToTable("PartCategories_md");

                entity.HasIndex(e => e.PartCategoryName)
                    .HasName("uk_PartCategoryName")
                    .IsUnique();

                entity.Property(e => e.PartCategoryId).HasColumnName("PartCategory_Id");

                entity.Property(e => e.PartCategoryName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PartSubcategoriesMd>(entity =>
            {
                entity.HasKey(e => e.PartSubcategoryId)
                    .HasName("pk_PartSubcategory_Id");

                entity.ToTable("PartSubcategories_md");

                entity.HasIndex(e => e.PartSubcategoryName)
                    .HasName("uk_PartSubcategoryName")
                    .IsUnique();

                entity.Property(e => e.PartSubcategoryId).HasColumnName("PartSubcategory_Id");

                entity.Property(e => e.PartSubcategoryName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<PartsMd>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("pk_Part_Id");

                entity.ToTable("Parts_md");

                entity.HasIndex(e => e.NameTag)
                    .HasName("uk_NameTag")
                    .IsUnique();

                entity.Property(e => e.PartId).HasColumnName("Part_Id");

                entity.Property(e => e.BackupSupplierId).HasColumnName("BackupSupplier_Id");

                entity.Property(e => e.CutsheetId).HasColumnName("Cutsheet_Id");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.Property(e => e.NameTag)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PartCategoryId).HasColumnName("PartCategory_Id");

                entity.Property(e => e.PartDescription).HasMaxLength(256);

                entity.Property(e => e.PartSubcategoryId).HasColumnName("PartSubcategory_Id");

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");

                entity.Property(e => e.UnitPrice).HasColumnType("smallmoney");

                entity.HasOne(d => d.BackupSupplier)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.BackupSupplierId)
                    .HasConstraintName("fk_BackupSuppliers_md");

                entity.HasOne(d => d.Cutsheet)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.CutsheetId)
                    .HasConstraintName("fk_Cutsheet_Id");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("fk_Manufacturer_Id");

                entity.HasOne(d => d.PartCategory)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.PartCategoryId)
                    .HasConstraintName("fk_PartCategories_md");

                entity.HasOne(d => d.PartSubcategory)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.PartSubcategoryId)
                    .HasConstraintName("fk_PartSubcategories_md");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PartsMd)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fk_Suppliers_md");
            });

            modelBuilder.Entity<PipeMaterialTypesMd>(entity =>
            {
                entity.HasKey(e => e.MaterialTypeId)
                    .HasName("pk_MaterialType_Id");

                entity.ToTable("PipeMaterialTypes_md");

                entity.HasIndex(e => e.MaterialType)
                    .HasName("uk_MaterialType")
                    .IsUnique();

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialType_Id");

                entity.Property(e => e.MaterialType)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ProjectsMd>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("pk_Project_Id");

                entity.ToTable("Projects_md");

                entity.HasIndex(e => e.FolderPath)
                    .HasName("uk_FolderPath")
                    .IsUnique();

                entity.HasIndex(e => e.ProjectNumber)
                    .HasName("uk_ProjectNumber")
                    .IsUnique();

                entity.Property(e => e.ProjectId).HasColumnName("Project_Id");

                entity.Property(e => e.AuxiliaryEngineer)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.FolderPath)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProjectAddress)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.ProjectCity)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ProjectCountry)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ProjectEngineer)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ProjectManager)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.ProjectNumber)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ProjectState)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.ProjectZipCode)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.SubmittedBy)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SubmittalSectionCategoriesMd>(entity =>
            {
                entity.HasKey(e => e.SubmittalSectionCategoryId)
                    .HasName("pk_SubmittalSectionCategory_Id");

                entity.ToTable("SubmittalSectionCategories_md");

                entity.HasIndex(e => e.SubmittalSectionCategory)
                    .HasName("uk_SubmittalSectionCategory")
                    .IsUnique();

                entity.Property(e => e.SubmittalSectionCategoryId).HasColumnName("SubmittalSectionCategory_Id");

                entity.Property(e => e.SubmittalSectionCategory)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<SubmittalSectionsMd>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("pk_Section_Id");

                entity.ToTable("SubmittalSections_md");

                entity.HasIndex(e => e.SectionName)
                    .HasName("uk_SectionName")
                    .IsUnique();

                entity.HasIndex(e => e.SectionNumber)
                    .HasName("uk_SectionNumber")
                    .IsUnique();

                entity.Property(e => e.SectionId).HasColumnName("Section_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("File_Type")
                    .HasMaxLength(32);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SubmittalSectionsMd)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("fk_Category_Id");
            });

            modelBuilder.Entity<SuppliersMd>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("pk_Supplier_Id");

                entity.ToTable("Suppliers_md");

                entity.HasIndex(e => e.SupplierName)
                    .HasName("uk_SupplierName")
                    .IsUnique();

                entity.Property(e => e.SupplierId).HasColumnName("Supplier_Id");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<ValveConnectionTypesMd>(entity =>
            {
                entity.HasKey(e => e.ValveConnectionTypeId)
                    .HasName("pk_ValveConnectionType_Id");

                entity.ToTable("ValveConnectionTypes_md");

                entity.HasIndex(e => e.ValveConnectionType)
                    .HasName("uk_ValveConnectionType")
                    .IsUnique();

                entity.Property(e => e.ValveConnectionTypeId).HasColumnName("ValveConnectionType_Id");

                entity.Property(e => e.ValveConnectionType)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<ValveTypesMd>(entity =>
            {
                entity.HasKey(e => e.ValveTypeId)
                    .HasName("pk_ValveType_Id");

                entity.ToTable("ValveTypes_md");

                entity.HasIndex(e => e.ModelNumber)
                    .HasName("uk_ModelNumber")
                    .IsUnique();

                entity.Property(e => e.ValveTypeId).HasColumnName("ValveType_Id");

                entity.Property(e => e.ActuatorFeedback).HasMaxLength(32);

                entity.Property(e => e.ActuatorPartNumber)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.BodyPattern).HasMaxLength(16);

                entity.Property(e => e.CloseOffPressurePsi).HasColumnName("CloseOffPressure_Psi");

                entity.Property(e => e.ModelNumber)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.OperatingSpan)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PartId).HasColumnName("Part_Id");

                entity.Property(e => e.PipeSizeInches).HasColumnName("PipeSize_Inches");

                entity.Property(e => e.ValveConnectionTypeId).HasColumnName("ValveConnectionType_Id");

                entity.Property(e => e.ValveService).HasMaxLength(128);

                entity.Property(e => e.ValveSizeInches).HasColumnName("ValveSize_Inches");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.ValveTypesMd)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("fk_Part_Id");

                entity.HasOne(d => d.ValveConnectionType)
                    .WithMany(p => p.ValveTypesMd)
                    .HasForeignKey(d => d.ValveConnectionTypeId)
                    .HasConstraintName("fk_ValveConnectionType_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
