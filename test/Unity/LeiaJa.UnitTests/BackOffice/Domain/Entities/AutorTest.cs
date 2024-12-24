namespace LeiaJa.UnitTests.BackOffice.Domain.Entities;
public class AutorTest
{
    
    #region NÃO CRIAR AUTOR SEM O NOME
        [Fact(DisplayName = "Não Cria Autor Sem o Nome")]
        public void Criar_Autor_NaoCriaAutorSemONome()
        {
            var autor = Assert.Throws<DomainExceptionValidation>(()=> new AutorEntity(1,"","Pedro"));
            Assert.Equal("O Nome é obrigatório", autor.Message);
        }
    #endregion

    #region NÃO CRIAR AUTOR SEM O SOBRENOME
        [Fact(DisplayName = "Não cria Autor sem o SobreNome")]
        public void Criar_Autor_NaoCriaAutorSemOSobreNome()
        {
            var autor = Assert.Throws<DomainExceptionValidation>(()=> new AutorEntity(1,"Test",""));
            Assert.Equal("O SobreNome é obrigatório", autor.Message);
        }
    #endregion

    #region NÃO CRIAR AUTOR SEM O ID
        [Fact(DisplayName = "Não cria Autor sem o ID")]
        public void Criar_Autor_NaoCriaAutorSemID()
        {
            var autor = Assert.Throws<DomainExceptionValidation>(()=> new AutorEntity(0,"Test","Test"));
            Assert.Equal("O ID do Usuario deve ser positiva", autor.Message);
        }
    #endregion

    #region NÃO CRIAR AUTOR SE O ID FOR NEGATIVA
        [Fact(DisplayName = "Não cria Autor se o ID for Negativa")]
        public void Criar_Autor_NaoCriaAutorSeIdForNegativa()
        {
            var autor = Assert.Throws<DomainExceptionValidation>(()=> new AutorEntity(-1,"Test","Test"));
            Assert.Equal("O ID do Usuario Não deve ser Negativo", autor.Message);
        }
    #endregion

    #region CRIAR AUTOR SEM ID
        [Fact(DisplayName = "Cria autor sem ID")]
        public void Criar_Autor_CriaAutorSemID()
        {
            var autor =  new AutorEntity("Test","Test");
            Assert.NotNull(autor);
        }
    #endregion

    #region CRIAR AUTOR COM ID
        [Fact(DisplayName = "Cria autor com Id")]
        public void Criar_Autor_CriaAutorComId()
        {
            var autor = new AutorEntity(1,"Test","Test");
            Assert.NotNull(autor);
        }
    #endregion

    #region EDITA AUTOR
        [Fact(DisplayName = "Editar autor com Id")]
        public void Editar_Autor_EditaAutor()
        {
            var autor = new AutorEntity("Test","Test");
            autor.Update("Test1","Test1");
            Assert.Equal("Test1", autor.Nome);
            Assert.Equal("Test1", autor.SobreNome);
        }
    #endregion


}
