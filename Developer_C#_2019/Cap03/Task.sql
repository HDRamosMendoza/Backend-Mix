-- TABLE GENRE
CREATE PROCEDURE usp_GetGenres(
	@FiltroPorNombre NVARCHAR(120))
AS
BEGIN
	SELECT 
		GenreId,
		Name 
	FROM Genre
	WHERE Name LIKE @FiltroPorNombre
END
GO
CREATE PROCEDURE usp_InsertGenre(
	@Nombre NVARCHAR(120))
AS
BEGIN
	INSERT INTO 
		Genre(Name)
	VALUES(@Nombre)
	SELECT SCOPE_IDENTITY()
END
GO
CREATE PROCEDURE usp_UpdateGenre(
	@Nombre NVARCHAR(120),
	@ID INT,
	@RESULT BIT OUTPUT)
AS
BEGIN
	UPDATE Genre 
	SET 
		Name=@Nombre
	WHERE GenreId = @id
	SET @RESULT = 1
END
GO
CREATE PROCEDURE usp_DeleteGenre(
	@ID INT)
AS
BEGIN
	DELETE FROM Genre
	WHERE GenreId = @ID
END
GO
-- TABLE ALBUM
CREATE PROCEDURE usp_GetAlbums(
	@FiltroPorNombre NVARCHAR(120))
AS
BEGIN
	SELECT 
		AlbumId,
		Title
	FROM Album
	WHERE Title LIKE @FiltroPorNombre
END
GO
execute usp_InsertAlbum 'Nuevo Album'
select * from Album

CREATE PROCEDURE usp_InsertAlbum(
	@Nombre NVARCHAR(120),
	@IdFK INT)
AS
BEGIN
	INSERT INTO Album(Title, ArtistId)
	VALUES(@Nombre, @IdFK)
	SELECT SCOPE_IDENTITY()
END
GO
CREATE PROCEDURE usp_UpdateAlbum(
	@Nombre NVARCHAR(120),
	@ID INT,
	@RESULT BIT OUTPUT)
AS
BEGIN
	UPDATE Album
	SET 
		Title=@Nombre
	WHERE AlbumId = @id
	SET @RESULT = 1
END
GO
CREATE PROCEDURE usp_DeleteAlbum(
	@ID INT)
AS
BEGIN
	DELETE FROM Album
	WHERE AlbumId = @ID
END