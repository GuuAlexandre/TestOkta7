CREATE TABLE [User]
(
 [Id]        int NOT NULL ,
 [Name]      varchar(255) NOT NULL ,
 [Email]     varchar(255) NOT NULL ,
 [Password]  varchar(255) NOT NULL 

	
 CONSTRAINT [PK_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

INSERT INTO [User] VALUES(1, 'Silas Goes', 'silas@okta7.com.br', 'ffc1088e5dce4f2a0fc77ae6a66d0f09e443017904d5ba95d8ba99b2d8edd7b7327f242c172882ded33cdccd01525e28adecaa5a95b2362c9c8dc91dec6b03c4')
INSERT INTO [User] VALUES(2, 'Thalia Marcantonio', 'thalia@okta7.com.br', 'ffc1088e5dce4f2a0fc77ae6a66d0f09e443017904d5ba95d8ba99b2d8edd7b7327f242c172882ded33cdccd01525e28adecaa5a95b2362c9c8dc91dec6b03c4')