namespace LeiaJa.IntegrationTest.Infrastructure.RepositoryAutor;
public class AutorRepositoryTests : IDisposable
{
    #region DATABASE
    private readonly AppDbContext _context;
    private readonly AutorRepository _repository;

    public AutorRepositoryTests()
    {
        // Configuração do banco de dados em memória
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDatabase")
            .LogTo(Console.WriteLine) // Logs de consulta no console
            .Options;

        _context = new AppDbContext(options);
        _repository = new AutorRepository(_context, Mock.Of<ILogger<AutorRepository>>());
    }

    public void Dispose()
    {
        // Limpa o banco após cada teste
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }
#endregion

    #region CRIAR AUTOR
        [Fact(DisplayName = "Salve Autor")]
        public async Task CreateAutorAsync_ShouldAddAutorToDatabase()
        {
            // Arrange
            var autor = new AutorEntity("João", "Silva");

            // Act
            var autores = await _repository.CreateAutorAsync(autor);

            // Assert
            Assert.NotNull(autores);
            Assert.Single(autores); // Deve conter 1 autor no banco
            Assert.Equal("João", autores[0].Nome);
            Assert.Equal("Silva", autores[0].SobreNome);
        }
    #endregion

    #region OBTER AUTOR

        [Fact(DisplayName = "Obter Lista de AUtores")]
        public async Task GetAllAutoresAsync_ShouldReturnPagedListOfAutores()
        {
            // Arrange
            var autores = new List<AutorEntity>
            {
                new AutorEntity(1, "Autor 1", "Sobrenome 1"),
                new AutorEntity(2, "Autor 2", "Sobrenome 2"),
                new AutorEntity(3, "Autor 3", "Sobrenome 3")
            };

            _context.Autores.AddRange(autores);
            await _context.SaveChangesAsync();

            // Act
            var result = await _repository.GetAllAutoresAsync(1, 2);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count); // Retorna apenas 2 autores por página
        }

        [Fact(DisplayName = "Obter Autor Quando Id For Encontrado")]
        public async Task GetAutorByIdAsync_ShouldReturnAutor_WhenAutorExists()
        {
            // Arrange
            var autor = new AutorEntity(1, "Maria", "Oliveira");
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();

            // Act
            var result = await _repository.GetAutorByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result!.Id);
            Assert.Equal("Maria", result.Nome);
            Assert.Equal("Oliveira", result.SobreNome);
        }

        [Fact(DisplayName = "Obter Autor Quando Id For Null")]
        public async Task GetAutorByIdAsync_ShouldReturnNull_WhenAutorDoesNotExist()
        {
            // Act
            var result = await _repository.GetAutorByIdAsync(999);

            // Assert
            Assert.Null(result);
        }
    #endregion

    #region DELETAR AUTOR
        [Fact(DisplayName = "Deletar Quando Autor For Encontrado")]
        public async Task DeleteAutorAsync_ShouldRemoveAutorFromDatabase_WhenAutorExists()
        {
            // Arrange
            var autor = new AutorEntity(1, "Carlos", "Souza");
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();

            // Act
            var deletedAutor = await _repository.DeleteAutorAsync(1);

            // Assert
            Assert.NotNull(deletedAutor);
            Assert.Equal(1, deletedAutor!.Id);
            Assert.Equal("Carlos", deletedAutor.Nome);

            var autorNoBanco = await _context.Autores.FindAsync(1);
            Assert.Null(autorNoBanco); // Deve ser removido
        }

        [Fact(DisplayName = "Deletar Quando Autor Não For Encontrado")]
        public async Task DeleteAutorAsync_ShouldReturnNull_WhenAutorDoesNotExist()
        {
            // Act
            var result = await _repository.DeleteAutorAsync(999);

            // Assert
            Assert.Null(result);
        }
    #endregion

    #region EDITAR AUTOR
        [Fact(DisplayName = "Editar Autor")]
        public async Task UpdateAutorAsync_ShouldUpdateAutorInDatabase()
        {
            // Arrange
            var autor = new AutorEntity(1, "Ana", "Santos");
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();

            // Atualizar os dados
            autor.Update("Ana Maria", "Santos Silva");

            // Act
            var updatedAutor = await _repository.UpdateAutorAsync(autor);

            // Assert
            Assert.NotNull(updatedAutor);
            Assert.Equal("Ana Maria", updatedAutor.Nome);
            Assert.Equal("Santos Silva", updatedAutor.SobreNome);

            var autorNoBanco = await _context.Autores.FindAsync(1);
            Assert.NotNull(autorNoBanco);
            Assert.Equal("Ana Maria", autorNoBanco.Nome);
            Assert.Equal("Santos Silva", autorNoBanco.SobreNome);
        }
    #endregion

}
