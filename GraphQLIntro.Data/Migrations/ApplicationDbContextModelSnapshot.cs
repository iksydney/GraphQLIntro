﻿// <auto-generated />
using System;
using GraphQLIntro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQLIntro.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraphQLIntro.Data.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("48d4de86-c8e1-4a53-9974-42488eee342d"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("a9b1f68b-089e-4d68-9872-32f753fddd48"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("32086f6b-afe8-4702-86fd-a2e4a524880c"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("18ff88f2-9db7-4462-9db0-473e956f3777"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("8fc6680e-d01a-42bb-80e1-dccf476a40be"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("78f63249-5604-4dbd-85f0-f0d8bf6fa803"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("d9c5ab01-02ca-4bce-8ee0-aa44f6e496e4"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SuperheroId = new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("GraphQLIntro.Data.Entities.SuperHeroe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SuperHeroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = "1.93",
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = "1.70",
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = "1.70",
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("GraphQLIntro.Data.Entities.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SuperHeroeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SuperHeroeId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf69db31-aede-4651-aad5-fd8ff9b4a524"),
                            Description = "He's always a step ahead.",
                            SuperHeroeId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            SuperPower = "Intellect."
                        },
                        new
                        {
                            Id = new Guid("cf379ba9-5e98-468d-9d12-43375254d3d4"),
                            Description = "Sublime fighting skills.",
                            SuperHeroeId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            SuperPower = "Fighting"
                        },
                        new
                        {
                            Id = new Guid("d880fe55-8b4e-4530-8abb-1a4f1ad87ca1"),
                            Description = "He got a lot of money",
                            SuperHeroeId = new Guid("4cc86166-bbe9-4c2a-a556-d3bc7e446dc6"),
                            SuperPower = "Wealth."
                        },
                        new
                        {
                            Id = new Guid("5690a958-2d51-438d-95a3-4f377578afb4"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperHeroeId = new Guid("e123e112-61f3-462e-8c23-a5332db0fc9c"),
                            SuperPower = "Deflect blaster power."
                        },
                        new
                        {
                            Id = new Guid("95b9335c-b893-4f18-8195-4af9123658f2"),
                            Description = "She's good at spying at people.",
                            SuperHeroeId = new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"),
                            SuperPower = "Espionage"
                        },
                        new
                        {
                            Id = new Guid("930bec5b-e31f-4b50-840a-21e0948fbb4b"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperHeroeId = new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"),
                            SuperPower = "Infiltration"
                        },
                        new
                        {
                            Id = new Guid("04a5c89f-80ac-4b8b-a6ee-c6138efa71c6"),
                            Description = "The knowledge of how to undermine others.",
                            SuperHeroeId = new Guid("16a2eb63-7235-4a2e-a034-9fd1054bb9db"),
                            SuperPower = "Subterfuge"
                        });
                });

            modelBuilder.Entity("GraphQLIntro.Data.Entities.Movie", b =>
                {
                    b.HasOne("GraphQLIntro.Data.Entities.SuperHeroe", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("GraphQLIntro.Data.Entities.Superpower", b =>
                {
                    b.HasOne("GraphQLIntro.Data.Entities.SuperHeroe", "SuperHeroe")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperHeroeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SuperHeroe");
                });

            modelBuilder.Entity("GraphQLIntro.Data.Entities.SuperHeroe", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}
