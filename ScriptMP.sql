USE [master]
GO
/****** Object:  Database [ProjectA]    Script Date: 05/03/2019 3:24:22 PM ******/
CREATE DATABASE [ProjectA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.NUMANSQL\MSSQL\DATA\ProjectA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjectA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.NUMANSQL\MSSQL\DATA\ProjectA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjectA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectA] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectA] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjectA] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectA', N'ON'
GO
ALTER DATABASE [ProjectA] SET QUERY_STORE = OFF
GO
USE [ProjectA]
GO
/****** Object:  Table [dbo].[Advisor]    Script Date: 05/03/2019 3:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advisor](
	[Id] [int] NOT NULL,
	[Designation] [int] NOT NULL,
	[Salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluation]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[TotalMarks] [int] NOT NULL,
	[TotalWeightage] [int] NOT NULL,
 CONSTRAINT [PK_Evaluation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created_On] [date] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupEvaluation]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupEvaluation](
	[GroupId] [int] NOT NULL,
	[EvaluationId] [int] NOT NULL,
	[ObtainedMarks] [int] NOT NULL,
	[EvaluationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupEvaluation] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[EvaluationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupProject]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupProject](
	[ProjectId] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC,
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupStudent]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudent](
	[GroupId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupStudent] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 05/03/2019 3:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NULL,
	[Contact] [varchar](20) NULL,
	[Email] [varchar](30) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 05/03/2019 3:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](max) NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectAdvisor]    Script Date: 05/03/2019 3:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectAdvisor](
	[AdvisorId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[AdvisorRole] [int] NOT NULL,
	[AssignmentDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectAdvisor] PRIMARY KEY CLUSTERED 
(
	[AdvisorId] ASC,
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 05/03/2019 3:24:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[RegistrationNo] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (1, 6, CAST(66300 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (2, 8, CAST(67000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (3, 7, CAST(67000 AS Decimal(18, 0)))
INSERT [dbo].[Advisor] ([Id], [Designation], [Salary]) VALUES (4, 7, CAST(67000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Evaluation] ON 

INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (4, N'mf', 10, 20)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (5, N'knf', 10, 20)
INSERT [dbo].[Evaluation] ([Id], [Name], [TotalMarks], [TotalWeightage]) VALUES (6, N'Fyp Proposal', 10, 10)
SET IDENTITY_INSERT [dbo].[Evaluation] OFF
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (3, CAST(N'2019-03-29' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (1005, CAST(N'2019-04-02' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (1006, CAST(N'2019-04-26' AS Date))
INSERT [dbo].[Group] ([Id], [Created_On]) VALUES (1008, CAST(N'2019-04-26' AS Date))
SET IDENTITY_INSERT [dbo].[Group] OFF
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (1005, 4, 9, CAST(N'2019-04-26T11:08:37.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (1005, 5, 8, CAST(N'2019-04-26T11:10:10.000' AS DateTime))
INSERT [dbo].[GroupEvaluation] ([GroupId], [EvaluationId], [ObtainedMarks], [EvaluationDate]) VALUES (1008, 6, 8, CAST(N'2019-04-26T11:23:00.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (1, 1006, CAST(N'2019-04-26T10:04:18.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (2, 1005, CAST(N'2019-04-26T09:42:51.000' AS DateTime))
INSERT [dbo].[GroupProject] ([ProjectId], [GroupId], [AssignmentDate]) VALUES (3, 1008, CAST(N'2019-04-26T11:08:23.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1005, 3, 3, CAST(N'2019-04-02T02:47:22.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1005, 4, 3, CAST(N'2019-04-26T09:59:43.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1008, 1, 3, CAST(N'2019-04-26T10:04:03.000' AS DateTime))
INSERT [dbo].[GroupStudent] ([GroupId], [StudentId], [Status], [AssignmentDate]) VALUES (1008, 2, 3, CAST(N'2019-04-26T10:04:03.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (1, N'Male', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (2, N'Female', N'GENDER')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (3, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (4, N'InActive', N'STATUS')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (6, N'Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (7, N'Associate Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (8, N'Assisstant Professor', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (9, N'Lecturer', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (10, N'Industry Professional', N'DESIGNATION')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (11, N'Main Advisor', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (12, N'Co-Advisror', N'ADVISOR_ROLE')
INSERT [dbo].[Lookup] ([Id], [Value], [Category]) VALUES (14, N'Industry Advisor', N'ADVISOR_ROLE')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (1, N'Numan', N'Arshad', N'03047689797', N'numan@gmail.com', CAST(N'2003-03-29T00:52:30.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (2, N'Umair', N'Yousaf', N'03046789765', N'umair@gmail.com', CAST(N'2000-06-29T18:39:00.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (3, N'Numair', N'Riaz', N'03049753678', N'numair@gmail.com', CAST(N'2001-06-02T02:45:39.000' AS DateTime), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Contact], [Email], [DateOfBirth], [Gender]) VALUES (4, N'Hafsa', N'Maqsood', N'03047865432', N'hafsa@gmail.com', CAST(N'1999-04-02T02:46:28.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (1, N'kfenbj', N'knfjbed')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (2, N'krfke', N'lsmnfkcen')
INSERT [dbo].[Project] ([Id], [Description], [Title]) VALUES (3, N'nnjd', N'lfkw')
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (1, 2, 11, CAST(N'2019-03-31T17:41:37.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (2, 2, 12, CAST(N'2019-04-02T18:41:19.000' AS DateTime))
INSERT [dbo].[ProjectAdvisor] ([AdvisorId], [ProjectId], [AdvisorRole], [AssignmentDate]) VALUES (3, 2, 14, CAST(N'2019-04-02T18:41:28.000' AS DateTime))
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (1, N'2016-CS-311')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (2, N'2016-CS-324')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (3, N'2016-CS-678')
INSERT [dbo].[Student] ([Id], [RegistrationNo]) VALUES (4, N'2016-CS-113')
ALTER TABLE [dbo].[Advisor]  WITH CHECK ADD  CONSTRAINT [FK_Advisor_Lookup] FOREIGN KEY([Designation])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Advisor] CHECK CONSTRAINT [FK_Advisor_Lookup]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Evaluation] FOREIGN KEY([EvaluationId])
REFERENCES [dbo].[Evaluation] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Evaluation]
GO
ALTER TABLE [dbo].[GroupEvaluation]  WITH CHECK ADD  CONSTRAINT [FK_GroupEvaluation_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupEvaluation] CHECK CONSTRAINT [FK_GroupEvaluation_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Group]
GO
ALTER TABLE [dbo].[GroupProject]  WITH CHECK ADD  CONSTRAINT [FK_GroupProject_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[GroupProject] CHECK CONSTRAINT [FK_GroupProject_Project]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudents_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudents_Lookup]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Group]
GO
ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_ProjectStudents_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_ProjectStudents_Student]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Lookup] FOREIGN KEY([Gender])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Lookup] FOREIGN KEY([AdvisorRole])
REFERENCES [dbo].[Lookup] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Lookup]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectAdvisor_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectAdvisor_Project]
GO
ALTER TABLE [dbo].[ProjectAdvisor]  WITH CHECK ADD  CONSTRAINT [FK_ProjectTeachers_Teacher] FOREIGN KEY([AdvisorId])
REFERENCES [dbo].[Advisor] ([Id])
GO
ALTER TABLE [dbo].[ProjectAdvisor] CHECK CONSTRAINT [FK_ProjectTeachers_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([Id])
REFERENCES [dbo].[Person] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
USE [master]
GO
ALTER DATABASE [ProjectA] SET  READ_WRITE 
GO
