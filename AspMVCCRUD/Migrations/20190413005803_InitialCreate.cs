using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspMVCCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseTables",
                columns: table => new
                {
                    courseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    coursename = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    coursetype = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTables", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "runningCourses",
                columns: table => new
                {
                    runningCourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainerName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    price = table.Column<int>(nullable: false),
                    numberOfStudents = table.Column<string>(nullable: true),
                    numberOfClasses = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_runningCourses", x => x.runningCourseId);
                });

            migrationBuilder.CreateTable(
                name: "RunningCoursesLists",
                columns: table => new
                {
                    RunningCoursesListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    trainerId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RunningCoursesLists", x => x.RunningCoursesListId);
                });

            migrationBuilder.CreateTable(
                name: "StudentPages",
                columns: table => new
                {
                    Roll = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    student_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPages", x => x.Roll);
                });

            migrationBuilder.CreateTable(
                name: "TeachersLists",
                columns: table => new
                {
                    TeachersListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    trianername = table.Column<string>(type: "varchar(100)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    completeCourse = table.Column<int>(nullable: false),
                    RemainPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersLists", x => x.TeachersListId);
                });

            migrationBuilder.CreateTable(
                name: "TeachersOwnLists",
                columns: table => new
                {
                    TeachersOwnListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseId = table.Column<int>(nullable: false),
                    completeCourse = table.Column<int>(nullable: false),
                    PointPerCourses = table.Column<int>(nullable: false),
                    NumberofClassPerCourses = table.Column<int>(nullable: false),
                    NumberofDoneClassPerCourses = table.Column<int>(nullable: false),
                    PickUpAmmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersOwnLists", x => x.TeachersOwnListId);
                });

            migrationBuilder.CreateTable(
                name: "TrainerRegs",
                columns: table => new
                {
                    trainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    c_Id = table.Column<int>(nullable: false),
                    courseName = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    CardNum = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainerRegs", x => x.trainerId);
                });

            migrationBuilder.CreateTable(
                name: "UserDoneCoursesInfos",
                columns: table => new
                {
                    UserDoneCoursesInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseId = table.Column<int>(nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    DoneCourses = table.Column<string>(type: "varchar(100)", nullable: false),
                    Grade = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDoneCoursesInfos", x => x.UserDoneCoursesInfoId);
                });

            migrationBuilder.CreateTable(
                name: "UserLogIns",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    phnNumber = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogIns", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "UserRunningCoursesInfos",
                columns: table => new
                {
                    UserRunningCoursesInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    courseId = table.Column<int>(nullable: false),
                    TrainerName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    CourseName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CompleteClasses = table.Column<int>(nullable: false),
                    remainingPoints = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRunningCoursesInfos", x => x.UserRunningCoursesInfoId);
                });

            migrationBuilder.CreateTable(
                name: "VideoLists",
                columns: table => new
                {
                    VideoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    VideoField = table.Column<string>(type: "nvarchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLists", x => x.VideoId);
                });

            migrationBuilder.CreateTable(
                name: "StudentsLists",
                columns: table => new
                {
                    StudentsListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    studentname = table.Column<string>(type: "varchar(100)", nullable: false),
                    password = table.Column<string>(type: "varchar(100)", nullable: false),
                    completeCourse = table.Column<int>(nullable: false),
                    DuePoints = table.Column<int>(nullable: false),
                    RunningCoursesListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsLists", x => x.StudentsListId);
                    table.ForeignKey(
                        name: "FK_StudentsLists_RunningCoursesLists_RunningCoursesListId",
                        column: x => x.RunningCoursesListId,
                        principalTable: "RunningCoursesLists",
                        principalColumn: "RunningCoursesListId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsLists_RunningCoursesListId",
                table: "StudentsLists",
                column: "RunningCoursesListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTables");

            migrationBuilder.DropTable(
                name: "runningCourses");

            migrationBuilder.DropTable(
                name: "StudentPages");

            migrationBuilder.DropTable(
                name: "StudentsLists");

            migrationBuilder.DropTable(
                name: "TeachersLists");

            migrationBuilder.DropTable(
                name: "TeachersOwnLists");

            migrationBuilder.DropTable(
                name: "TrainerRegs");

            migrationBuilder.DropTable(
                name: "UserDoneCoursesInfos");

            migrationBuilder.DropTable(
                name: "UserLogIns");

            migrationBuilder.DropTable(
                name: "UserRunningCoursesInfos");

            migrationBuilder.DropTable(
                name: "VideoLists");

            migrationBuilder.DropTable(
                name: "RunningCoursesLists");
        }
    }
}
