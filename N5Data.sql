USE [DataChallengeN5]
GO
SET IDENTITY_INSERT [dbo].[PermissionTypes] ON 

INSERT [dbo].[PermissionTypes] ([Id], [Description], [CreatedAt], [UpdatedAt]) VALUES (1, N'Administrator', CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PermissionTypes] ([Id], [Description], [CreatedAt], [UpdatedAt]) VALUES (2, N'Editor', CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PermissionTypes] ([Id], [Description], [CreatedAt], [UpdatedAt]) VALUES (3, N'Supervisor', CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PermissionTypes] ([Id], [Description], [CreatedAt], [UpdatedAt]) VALUES (4, N'Tech Lead', CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PermissionTypes] ([Id], [Description], [CreatedAt], [UpdatedAt]) VALUES (5, N'Product Owner', CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-22T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PermissionTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([Id], [EmployeeName], [EmployeeLastname], [PermissionTypeId], [PermissionDate], [CreatedAt], [UpdatedAt]) VALUES (1, N'Gian Franco', N'Wallen Gomez', 2, CAST(N'2022-07-22T20:00:37.2560000' AS DateTime2), CAST(N'2022-07-22T15:00:48.9298944' AS DateTime2), CAST(N'2022-07-22T15:20:36.3945154' AS DateTime2))
INSERT [dbo].[Permissions] ([Id], [EmployeeName], [EmployeeLastname], [PermissionTypeId], [PermissionDate], [CreatedAt], [UpdatedAt]) VALUES (2, N'Keith James', N'Wallen', 5, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-07-23T23:08:21.4420945' AS DateTime2), CAST(N'2022-07-23T23:08:44.0637702' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
