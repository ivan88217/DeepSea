using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DeepSea.Models;
using Microsoft.AspNetCore.Identity;

namespace DeepSea.Data;
public class ApplicationDbContext : IdentityDbContext<IdentityUserModel>
{
#pragma warning disable CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618 // 退出建構函式時，不可為 Null 的欄位必須包含非 Null 值。請考慮宣告為可為 Null。
        : base(options)
    {

    }

    public DbSet<UserOwnUnits> MemberOwnUnits { get; set; }
    public DbSet<IdentityUserModel> User { get; set; }
    public DbSet<Unit> Unit { get; set; }
    public DbSet<House> House { get; set; }
    public DbSet<Alliance> Alliance { get; set; }
    public DbSet<AttendanceRecord> AttendanceRecord { get; set; }
    public DbSet<AttendanceRecordDetail> AttendanceRecordDetail { get; set; }
    public DbSet<AttendanceTempRecord> AttendanceTempRecord { get; set; }
    public DbSet<Team> Team {  get; set; }
    public DbSet<TeamUsers> TeamUsers { get; set; }
    public DbSet<TeamUsersUnitDetail> TeamUsersUnitDetail { get; set; }
    public DbSet<HouseMember> HouseMember { get; set; }
    public DbSet<HouseMemberDetail> HouseMemberDetail { get; set; }

    

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        //builder.Entity<IdentityUserModel>().HasOne(user => user.House).WithMany(house => house.Members).HasForeignKey(ium => ium.HouseId);
        //builder.Entity<House>().HasOne(house => house.Alliance).WithMany(alliance => alliance.House);
        builder.Entity<IdentityUserModel>()
            .HasMany(user => user.Units)
            .WithMany(unit => unit.Users)
            .UsingEntity<UserOwnUnits>
            (
            );

        builder.Entity<Alliance>().HasData(new Alliance { Id = 1, Name = "3公分" });
        builder.Entity<House>().HasData(new House { Id = 1, Name = "3cm感謝祭", AllianceId = 1 });

    }
}
