USE MusicStore;

SET IDENTITY_INSERT tblGenre ON;
INSERT INTO tblGenre (Id, Name)
VALUES (1, N'Pop'),
		(2, N'Rock'),
		(3, N'Blues'),
		(4, N'Jazz'),
		(5, N'Classic'),
		(6, N'Metal'),
		(7, N'Hip-Hop'),
		(8, N'Trip-Hop'),
		(9, N'Reggae'),
		(10, N'Punk'),
		(11, N'Progressive'),
		(12, N'Electrotic'),
		(13, N'House'),
		(14, N'Noize'),
		(15, N'Experimental'),
		(16, N'Rap'),
		(17, N'Avantguard'),
		(18, N'ALternative'),
		(19, N'Metalcore'),
		(20, N'Stoner'),
		(21, N'Swing'),
		(22, N'RnB'),
		(23, N'Cult Classics')
SET IDENTITY_INSERT tblGenre OFF;

SET IDENTITY_INSERT tblArtist ON;
INSERT INTO tblArtist (Id, Name)
VALUES (1, N'Pink Floyd'),
		(2, N'Dream Theater'),
		(3, N'UNKLE'),
		(4, N'Garbage'),
		(5, N'Porcupine Tree'),
		(6, N'Sex Pistols'),
		(7, N'Ramones'),
		(8, N'Metallica'),
		(9, N'Benny Goodman'),
		(10, N'Louis Armstrong'),
		(11, N'Prodigy'),
		(12, N'Recoil'),
		(13, N'Michael Jackson'),
		(14, N'Deep Purple'),
		(15, N'Dire Straits'),
		(16, N'Sting'),
		(17, N'Bach'),
		(18, N'Zimmer'),
		(19, N'Bob Marley'),
		(20, N'2Pac'),
		(21, N'Eminem'),
		(22, N'Britney Spears'),
		(23, N'Nickelback'),
		(24, N'Daft Punk'),
		(25, N'Disturbed'),
		(26, N'Killswitch Engage'),
		(27, N'Black eyed Peas');
SET IDENTITY_INSERT tblArtist OFF;

SET IDENTITY_INSERT tblAlbum ON;
INSERT INTO tblAlbum (Id, ArtistId, Name, [Year], RatingAllMusicCom)
VALUES (1, 1, N'Dark side of the moon', 1973, 10),
		(2, 1, N'Wish you were here', 1975, 10),
		(3, 2, N'Images & Words', 1992, 9),
		(4, 2, N'A dramatic turn of events', 2011, 6),
		(5, 3, N'Psyence Fiction', 1998, 8),
		(6, 4, N'Garbage', 1995, 9),
		(7, 5, N'Lightdub Sun', 2000, 8),
		(8, 5, N'Fear of a Blank Planet', 2007, 9),
		(9, 6, N'Never Mind the Bollocks Here''s the Sex Pistols', 1977, 10),
		(10, 7, N'Ramones', 1976, 10),
		(11, 8, N'Master of Puppets', 1986, 10),
		(12, 8, N'Load', 1996, 5),
		(13, 9, N'Live at Carnegie Hall: 1938 Complete', 1950, 10),
		(14, 10, N'Ella and Louis', 1956, 9),
		(15, 11, N'Experience', 1992, 10),
		(16, 12, N'Liquid', 2000, 8),
		(17, 13, N'Off the Wall', 1979, 10),
		(18, 13, N'Thriller', 1982, 10),
		(19, 14, N'Machine Head', 1972, 10),
		(20, 14, N'Slaves and Masters', 1990, 4),
		(21, 15, N'Making Movies', 1981, 9),
		(22, 16, N'Nothing like the Sun', 1987, 9),
		(23, 17, N'Joseff Sebastian Bach Remastered', 2004, NULL),
		(24, 18, N'Film music of Hans Zimmer', 2007, 7),
		(25, 19, N'Burnin''', 1973, 10),
		(26, 20, N'Me against the world', 1995, 10),
		(27, 21, N'The Slim-Shady LP', 1999, 10),
		(28, 21, N'Relapse', 2009, 8),
		(29, 22, N'Oops!...I Did It Again', 2000, 8),
		(30, 23, N'Silver Side Up', 2001, 6),
		(31, 24, N'Discovery', 2001, 10),
		(32, 25, N'Believe', 2002, 8),
		(33, 26, N'As Daylight Dies', 2006, 9),
		(34, 27, N'Monkey Business', 2005, 5);
SET IDENTITY_INSERT tblAlbum OFF;

SET IDENTITY_INSERT tblAlbumGenre ON;
INSERT INTO tblAlbumGenre (Id, AlbumId, GenreID)
VALUES (1, 1, 2), (2, 1, 11), (3, 1, 23), --Dark Side Of the Moon
		(4, 2, 2), (5, 2, 11), (6, 2, 23), --Wish you were here
		(7, 3, 2), (8, 3, 11), (9, 3, 6), --Images & Words
		(10, 4, 2), (11, 4, 11), (12, 4, 6), --Dramatic turn of events
		(13, 5, 1), (14, 5, 16), (15, 5, 12), (16, 5, 8), --Psyence Fiction
		(17, 6, 2), (18, 6, 8), (19, 6, 18), --Garbage
		(20, 7, 2), (21, 7, 11), --Lightdub Sun
		(22, 8, 2), (23, 8, 11), (24, 8, 6), --Fear pf the blank planet
		(25, 9, 2), (26, 9, 23), (27, 9, 10), --Sex Pistols
		(28, 10, 2), (29, 10, 23), (30, 10, 10), --Ramones
		(31, 11, 2), (32, 11, 23), (33, 11, 6), --Master of puppets
		(34, 12, 2), (35, 12, 6), (36, 12, 3), --Load
		(37, 13, 4), (38, 13, 23), --Benny Goodman
		(39, 14, 4), (40, 14, 23), --Armstrong
		(41, 15, 12), --Prodigy Experience
		(42, 16, 12), (43, 16, 2), (44, 16, 18), (45, 16, 15), --Experience
		(46, 17, 1), (47, 17, 23), (48, 17, 22), --Off the wall
		(49, 18, 1), (50, 18, 23), (51, 18, 22), --Thriller
		(52, 19, 2), (53, 19, 23), --Machine Head
		(54, 20, 2), --Slaves & masters
		(55, 21, 2), (56, 21, 1), (57, 21, 3), --Making moviews
		(58, 22, 1), (59, 22, 2), --Nothing like the sun Sting
		(60, 23, 5), (61, 23, 23), --Bach
		(62, 24, 5), --Zimmer Film Music
		(63, 25, 9), (64, 25, 23), --Birnin' Marley
		(65, 26, 16), (66, 26, 23), --Me against the world 2PAC
		(67, 27, 16), (68, 27, 23), --The Slim-Shady LP
		(69, 28, 16), --Relapse Eminem
		(70, 29, 1), --Oops! I did it again
		(71, 30, 2), (72, 30, 6), (73, 30, 18), --Silver Side Up
		(74, 31, 1), (75, 31, 12), (76, 31, 13), --Discovery
		(77, 32, 18), (78, 32, 2), (79, 32, 6), --Believe
		(80, 33, 18), (81, 33, 2), (82, 33, 6), (83, 33, 11), --As daylight dies
		(84, 34, 7), (85, 34, 16), (86, 34, 22); --Monkey business
SET IDENTITY_INSERT tblAlbumGenre OFF;

SET IDENTITY_INSERT tblMusicShop ON;
INSERT INTO tblMusicShop (Id, ProfitTotal, ExpenceTotal)
VALUES (1, 0, 0);
SET IDENTITY_INSERT tblMusicShop OFF;

SET IDENTITY_INSERT tblSeller ON;
INSERT INTO tblSeller (Id, ShopId, Name, Surname, PassportID)
VALUES (1, 1, N'Ben', N'Gann', N'KC0293293'),
		(2, 1, N'Johny', N'Sins', N'KC2165135');
SET IDENTITY_INSERT tblSeller OFF;

SET IDENTITY_INSERT tblDistributor ON;
INSERT INTO tblDistributor(Id, Name)
VALUES (1, N'Relapse'),
		(2, N'Epic');
SET IDENTITY_INSERT tblDistributor OFF;

SET IDENTITY_INSERT tblDistributorAlbums ON;
INSERT INTO tblDistributorAlbums (Id, DistributorId, AlbumId, Price)
VALUES (1, 1, 1, 10), (2, 1, 2, 10), (3, 1, 3, 10), (4, 1, 4, 10),
		(5, 1, 5, 10), (6, 1, 6, 10), (7, 1, 7, 10), (8, 1, 8, 10),
		(9, 1, 9, 10), (10, 1, 10, 10), (11, 1, 11, 10), (12, 1, 12, 10),
		(13, 1, 13, 10), (14, 1, 14, 10), (15, 1, 15, 10), (16, 1, 16, 10),
		(17, 1, 17, 10), (18, 1, 18, 10), (19, 1, 19, 10), (20, 1, 20, 10),
		(21, 2, 10, 15), (22, 2, 11, 15), (23, 2, 12, 15), (24, 2, 13, 15),
		(25, 2, 14, 15), (26, 2, 15, 15), (27, 2, 16, 15), (28, 2, 17, 15),
		(29, 2, 18, 15), (30, 2, 19, 15), (31, 2, 20, 15), (32, 2, 21, 15),
		(33, 2, 22, 15), (34, 2, 23, 15), (35, 2, 24, 15), (36, 2, 25, 15),
		(37, 2, 26, 15), (38, 2, 27, 15), (39, 2, 28, 15), (40, 2, 29, 15),
		(41, 2, 30, 15), (42, 2, 31, 15), (43, 2, 32, 15), (44, 2, 33, 15);
SET IDENTITY_INSERT tblDistributorAlbums OFF;		