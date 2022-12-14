// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DangThiAnhBTH2.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20221107152911_Personupdate")]
    partial class Personupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("DangThiAnhBTH2.Models.Employee", b =>
                {
                    b.Property<string>("EmpID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmpName")
                        .HasColumnType("TEXT");

                    b.HasKey("EmpID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DangThiAnhBTH2.Models.Person", b =>
                {
                    b.Property<string>("PerID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("PerName")
                        .HasColumnType("TEXT");

                    b.HasKey("PerID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("DangThiAnhBTH2.Models.Student", b =>
                {
                    b.Property<string>("StdID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("StdName")
                        .HasColumnType("TEXT");

                    b.HasKey("StdID");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
