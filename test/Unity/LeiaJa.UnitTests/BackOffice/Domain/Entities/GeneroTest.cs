namespace LeiaJa.UnitTests.BackOffice.Domain.Entities;
public class GeneroTest
{
    #region NÃO CRIAR GENERO SEM O ID
        [Fact(DisplayName = "Não Cria Genero Sem o ID")]
        public void Criar_Genero_NaoCriaGeneroSemID()
        {
            var genero = Assert.Throws<DomainExceptionValidation>(()=> new GeneroEntity(0,"Test"));
            Assert.Equal("O ID do Genero deve ser positiva", genero.Message);
        }
    #endregion

    #region NÃO CRIA GENERO SE ID FOR NEGATIVA
        [Fact(DisplayName = "Não Cria Genero Se ID For Negativa")]
        public void Criar_Genero_NaoCriaGeneroSeOIdForNegativa()
        {
            var genero = Assert.Throws<DomainExceptionValidation>(()=> new GeneroEntity(-1,"Test"));
            Assert.Equal("O ID do Genero Não deve ser Negativo",genero.Message);
        }
    #endregion

    #region NÃO CRIA GENERO SEM O NOME
        [Fact(DisplayName = "Não Cria Genero Sem O Nome")]
        public void Criar_Genero_NaoCriaGeneroSemONome()
        {
            var genero = Assert.Throws<DomainExceptionValidation>(()=> new GeneroEntity(1,""));
            Assert.Equal("O Genero é obrigatório", genero.Message);
        }
    #endregion

    #region CRIA GENERO SEM O ID
        [Fact(DisplayName = "Cria Genero Sem O ID")]
        public void Criar_Genero_CriaGeneroSemID()
        {
            var genero = new GeneroEntity("Test");
            Assert.NotNull(genero);
        }
    #endregion

    #region CRIA GENERO COM ID
        [Fact(DisplayName = "Cria Genero Com ID")]
        public void Criar_GeneroCriaGeneroComID()
        {
            var genero = new GeneroEntity(1, "Test");
            Assert.NotNull(genero);
        }
    #endregion

    #region EDITAR GENERO SEM ID
        [Fact(DisplayName = "Editar Genero Sem ID")]
        public void Editar_PGenero_EditarGeneroSemID()
        {
            var genero = new GeneroEntity("Test");
            genero.Update("Test1");
            Assert.Equal("Test1",genero.Genero);
        }
    #endregion

    #region EDITAR GENERO COM ID
        [Fact(DisplayName = "Editar Genero Com Id")]
        public void Editar_Genero_EditarGeneroComID()
        {
            var genero = new GeneroEntity(1,"Test");
            genero.Update("Test");
            Assert.Equal("Test", genero.Genero);
        }
    #endregion

}
