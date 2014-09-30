CREATE TABLE [dbo].[login]
(
	[userId]    INT            NOT NULL,
    [userName]  NVARCHAR (255) NULL,
    [surname]   NVARCHAR (255) NULL,
    [passwd]    NVARCHAR (255) NULL,
    [loginName] NVARCHAR (255) NULL,
    [lvl]       SMALLINT       NULL,
	CONSTRAINT [aaaaalogin_PK] PRIMARY KEY NONCLUSTERED ([userId] ASC)
);

CREATE NONCLUSTERED INDEX [loginuserName]
    ON [dbo].[login]([userName] ASC);


CREATE NONCLUSTERED INDEX [loginsurname]
    ON [dbo].[login]([surname] ASC);


CREATE NONCLUSTERED INDEX [Permissionslogin]
    ON [dbo].[login]([lvl] ASC);


CREATE UNIQUE NONCLUSTERED INDEX [loginName]
    ON [dbo].[login]([loginName] ASC);

CREATE TABLE [dbo].[secretQ] (
    [questionID] INT            NOT NULL,
    [question]   NVARCHAR (255) NULL,
    CONSTRAINT [aaaaasecretQ_PK] PRIMARY KEY NONCLUSTERED ([questionID] ASC)
);

CREATE TABLE [dbo].[userProfiles] (
    [userId]   INT            NOT NULL,
    [address]  NVARCHAR (255) DEFAULT ('-') NULL,
    [mobPhone] INT            DEFAULT ((0)) NULL,
    [phone]    INT            DEFAULT ((0)) NULL,
    [city]     NVARCHAR (255) DEFAULT ('-') NULL,
    [country]  NVARCHAR (255) DEFAULT ('-') NULL,
    [secretQ]  INT            DEFAULT ((1)) NULL,
    [secretA]  NVARCHAR (255) DEFAULT ('-') NULL,
    [dataOB]   DATETIME       DEFAULT (((1)/(1))/(1001)) NULL,
    [email]    NVARCHAR (255) DEFAULT ('-') NULL,
    [dateOJ]   DATETIME       DEFAULT (((1)/(1))/(1001)) NULL,
    CONSTRAINT [aaaaauserProfiles_PK] PRIMARY KEY NONCLUSTERED ([userId] ASC),
    CONSTRAINT [userProfiles_FK01] FOREIGN KEY ([secretQ]) REFERENCES [dbo].[secretQ] ([questionID]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [userProfiles_FK00] FOREIGN KEY ([userId]) REFERENCES [dbo].[login] ([userId]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE UNIQUE NONCLUSTERED INDEX [loginuserProfiles]
    ON [dbo].[userProfiles]([userId] ASC);


CREATE NONCLUSTERED INDEX [secretQuserProfiles]
    ON [dbo].[userProfiles]([secretQ] ASC);

CREATE TABLE [dbo].[userImages] (
    [userId] INT             NOT NULL,
    [image]  VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC)
);
INSERT INTO secretQ VALUES (1, 'What was your firts pet name?');
INSERT INTO secretQ VALUES (2, 'What was the name of your high school?');
INSERT INTO secretQ VALUES (3, 'What was the name of the city you were born?');
INSERT INTO secretQ VALUES (4, 'What was the name of the hospital you were born?');
INSERT INTO secretQ VALUES (5, 'What''s the name of the city your wife/husband was born?');
INSERT INTO login VALUES (0,'W','W','q','Q',5);
INSERT INTO userProfiles VALUES (0,'Q',0,0,'Q','Q',1,'Q',01/01/1990,'Q',01/01/1990);