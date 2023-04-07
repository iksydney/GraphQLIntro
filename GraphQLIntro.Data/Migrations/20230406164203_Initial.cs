using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLIntro.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_SuperHeroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperHeroeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_SuperHeroes_SuperHeroeId",
                        column: x => x.SuperHeroeId,
                        principalTable: "SuperHeroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SuperHeroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", "1.70", "Black Widow" });

            migrationBuilder.InsertData(
                table: "SuperHeroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", "1.93", "Batman" });

            migrationBuilder.InsertData(
                table: "SuperHeroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", "1.70", "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("18ff88f2-9db7-4462-9db0-473e956f3777"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("32086f6b-afe8-4702-86fd-a2e4a524880c"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "The Dark Knight Rises" },
                    { new Guid("48d4de86-c8e1-4a53-9974-42488eee342d"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "Batman Begins" },
                    { new Guid("78f63249-5604-4dbd-85f0-f0d8bf6fa803"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("8fc6680e-d01a-42bb-80e1-dccf476a40be"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("a9b1f68b-089e-4d68-9872-32f753fddd48"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "The Dark Knight" },
                    { new Guid("d9c5ab01-02ca-4bce-8ee0-aa44f6e496e4"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"), "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperHeroeId", "SuperPower" },
                values: new object[,]
                {
                    { new Guid("04a5c89f-80ac-4b8b-a6ee-c6138efa71c6"), "The knowledge of how to undermine others.", new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"), "Subterfuge" },
                    { new Guid("5690a958-2d51-438d-95a3-4f377578afb4"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"), "Deflect blaster power." },
                    { new Guid("930bec5b-e31f-4b50-840a-21e0948fbb4b"), "She knows how to infiltrate the enemy.", new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"), "Infiltration" },
                    { new Guid("95b9335c-b893-4f18-8195-4af9123658f2"), "She's good at spying at people.", new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"), "Espionage" },
                    { new Guid("bf69db31-aede-4651-aad5-fd8ff9b4a524"), "He's always a step ahead.", new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "Intellect." },
                    { new Guid("cf379ba9-5e98-468d-9d12-43375254d3d4"), "Sublime fighting skills.", new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "Fighting" },
                    { new Guid("d880fe55-8b4e-4530-8abb-1a4f1ad87ca1"), "He got a lot of money", new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"), "Wealth." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperHeroeId",
                table: "Superpowers",
                column: "SuperHeroeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}
