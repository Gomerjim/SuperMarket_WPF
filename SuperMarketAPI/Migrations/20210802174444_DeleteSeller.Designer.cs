// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperMarketAPI.Data;

namespace SuperMarketAPI.Migrations
{
    [DbContext(typeof(SuperContext))]
    [Migration("20210802174444_DeleteSeller")]
    partial class DeleteSeller
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperMarketAPI.Data.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SuperMarketAPI.Data.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("ProdName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProdPrice")
                        .HasColumnType("float");

                    b.Property<int>("ProdQty")
                        .HasColumnType("int");

                    b.HasKey("ProdId");

                    b.HasIndex("CatId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SuperMarketAPI.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SuperMarketAPI.Data.Product", b =>
                {
                    b.HasOne("SuperMarketAPI.Data.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SuperMarketAPI.Data.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
