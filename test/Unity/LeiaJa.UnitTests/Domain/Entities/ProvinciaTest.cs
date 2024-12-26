namespace LeiaJa.UnitTests.Domain.Entities;
public class ProvinciaTest
{
    #region NÃO CRIA PROVINCIA SEM O ID
        [Fact(DisplayName = "Não Cria Provincia Sem O ID")]
        public void Criar_Provincia_NaoCriaPronviciaSemOId()
        {
            var provincia = Assert.Throws<DomainExceptionValidation>(()=> new ProvinciaEntity(0,"Test"));
            Assert.Equal("O ID da Provincia deve ser positiva", provincia.Message);
    }
    #endregion

    #region NÃO CRIA PROVINCIA SE ID FOR NEGATIVA
        [Fact(DisplayName = "Não Cria Provincia Se ID For Negativa")]
        public void Criar_Provincia_NaoCriaPronviciaSeOIdForNegativa()
        {
            var provincia = Assert.Throws<DomainExceptionValidation>(()=> new ProvinciaEntity(-1,"Test"));
            Assert.Equal("O ID da Provincia Não deve ser Negativo",provincia.Message);
        }
    #endregion

    #region NÃO CRIA PROVINCIA SEM O NOME
        [Fact(DisplayName = "Não Cria Provincia Sem O Nome")]
        public void Criar_Provincia_NaoCriaPronviciaSemONome()
        {
            var provincia = Assert.Throws<DomainExceptionValidation>(()=> new ProvinciaEntity(1,""));
            Assert.Equal("A Provincia é obrigatório", provincia.Message);
        }
    #endregion

    #region CRIA PROVINCIA SEM O ID
        [Fact(DisplayName = "Cria Provincia Sem O ID")]
        public void Criar_Provincia_CriaProvinciaSemID()
        {
            var provincia = new ProvinciaEntity("Test");
            Assert.NotNull(provincia);
        }
    #endregion

    #region CRIA PROVINCIA COM ID
        [Fact(DisplayName = "Cria Provincia Com ID")]
        public void Criar_Provincia_CriaProvinciaComID()
        {
            var provincia = new ProvinciaEntity(1, "Test");
            Assert.NotNull(provincia);
        }
    #endregion

    #region EDITAR PROVINCIA SEM ID
        [Fact(DisplayName = "Editar Provincia Sem ID")]
        public void Editar_Provincia_EditarPtovinciaSemID()
        {
            var provincia = new ProvinciaEntity("Test");
            provincia.Update("Test1");
            Assert.Equal("Test1",provincia.Provincia);
        }
    #endregion

    #region EDITAR PROVINCIA COM ID
        [Fact(DisplayName = "Editar Provincia Com Id")]
        public void Editar_Provincia_EditarProvinciaComID()
        {
            var provincia = new ProvinciaEntity(1,"Test");
            provincia.Update("Test");
            Assert.Equal("Test", provincia.Provincia);
        }
    #endregion

}
