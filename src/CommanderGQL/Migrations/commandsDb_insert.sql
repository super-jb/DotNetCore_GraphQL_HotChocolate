USE [CommandsDB]
GO

SET IDENTITY_INSERT [dbo].[Platforms] ON 
GO
INSERT [dbo].[Platforms] ([Id], [Name], [LicenseKey]) VALUES (1, N'.NET', NULL)
GO
INSERT [dbo].[Platforms] ([Id], [Name], [LicenseKey]) VALUES (2, N'Docker', NULL)
GO
INSERT [dbo].[Platforms] ([Id], [Name], [LicenseKey]) VALUES (3, N'Windows', NULL)
GO
SET IDENTITY_INSERT [dbo].[Platforms] OFF
GO

SET IDENTITY_INSERT [dbo].[Commands] ON 
GO
INSERT [dbo].[Commands] ([Id], [HowTo], [CommandLine], [PlatformId]) VALUES (1, N'Build a project', N'dotnet build', 1)
GO
INSERT [dbo].[Commands] ([Id], [HowTo], [CommandLine], [PlatformId]) VALUES (2, N'Run a project', N'dotnet run', 1)
GO
INSERT [dbo].[Commands] ([Id], [HowTo], [CommandLine], [PlatformId]) VALUES (3, N'Start docker compose', N'docker-compose up -d', 2)
GO
INSERT [dbo].[Commands] ([Id], [HowTo], [CommandLine], [PlatformId]) VALUES (4, N'Stop docker compose', N'docker-compose stop', 2)
GO
SET IDENTITY_INSERT [dbo].[Commands] OFF
GO
