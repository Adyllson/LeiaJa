namespace LeiaJa.UnitTests.BackOffice.Domain.Entities;
public class CategoriaTest
{
    #region NÃO CRIAR CATEGORIA SEM O ID
    [Fact(DisplayName = "Não Cria Categoria Sem o ID")]
    public void Criar_Categoria_NaoCriaCategoriaSemID()
    {
        var categoria = Assert.Throws<DomainExceptionValidation>(()=> new CategoriaEntity(0,"Test"));
        Assert.Equal("O ID da Categoria deve ser positiva", categoria.Message);
    }
    #endregion

    #region NÃO CRIA CATEGORIA SE ID FOR NEGATIVA
        [Fact(DisplayName = "Não Cria Categoria Se ID For Negativa")]
        public void Criar_Categoria_NaoCriaCategoriaSeOIdForNegativa()
        {
            var categoria = Assert.Throws<DomainExceptionValidation>(()=> new CategoriaEntity(-1,"Test"));
            Assert.Equal("O ID da Categoria Não deve ser Negativo",categoria.Message);
        }
    #endregion

    #region NÃO CRIA CATEGORIA SEM O NOME
        [Fact(DisplayName = "Não Cria Categoria Sem O Nome")]
        public void Criar_Categoria_NaoCriaCategoriaSemONome()
        {
            var categoria = Assert.Throws<DomainExceptionValidation>(()=> new CategoriaEntity(1,""));
            Assert.Equal("A Categoria é obrigatório", categoria.Message);
        }
    #endregion

    #region CRIA CATEGORIA SEM O ID
        [Fact(DisplayName = "Cria Categoria Sem O ID")]
        public void Criar_Categoria_CriaCategoriaSemID()
        {
            var categoria = new CategoriaEntity("Test");
            Assert.NotNull(categoria);
        }
    #endregion

    #region CRIA CATEGORIA COM ID
        [Fact(DisplayName = "Cria Categoria Com ID")]
        public void Criar_GeneroCriaGeneroComID()
        {
            var categoria = new CategoriaEntity(1, "Test");
            Assert.NotNull(categoria);
        }
    #endregion

    #region EDITAR CATEGORIA SEM ID
        [Fact(DisplayName = "Editar Categoria Sem ID")]
        public void Editar_PGenero_EditarGeneroSemID()
        {
            var categoria = new CategoriaEntity("Test");
            categoria.Update("Test1");
            Assert.Equal("Test1",categoria.Categoria);
        }
    #endregion

    #region EDITAR CATEGORIA COM ID
        [Fact(DisplayName = "Editar Categoria Com Id")]
        public void Editar_Genero_EditarGeneroComID()
        {
            var categoria = new CategoriaEntity(1,"Test");
            categoria.Update("Test");
            Assert.Equal("Test", categoria.Categoria);
        }
    #endregion

}
