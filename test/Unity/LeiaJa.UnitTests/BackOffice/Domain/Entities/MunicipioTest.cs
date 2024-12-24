namespace LeiaJa.UnitTests.BackOffice.Domain.Entities;
public class MunicipioTest
{
    #region NÃO CRIA MUNICIPIO SEM O ID
        [Fact(DisplayName = "Não Municipio Sem O ID")]
        public void Criar_Municipio_NaoCriarMunicipioSemOId()
        {
            var municipio = Assert.Throws<DomainExceptionValidation>(()=> new MunicipioEntity(0,"Test",1));
            Assert.Equal("O ID do Municipio deve ser positiva", municipio.Message);
        }
    #endregion

    #region NÃO CRIA MUNICIPIO SE O ID FOR NEGATIVA
        [Fact(DisplayName = "Não Municipio Se O ID For Negativa")]
        public void Criar_Municpio_NaoCriarMunicipioSeOIdForNegativa()
        {
            var municipio = Assert.Throws<DomainExceptionValidation>(()=> new MunicipioEntity(-1,"Test",1));
            Assert.Equal("O ID do Municipio Não deve ser Negativo", municipio.Message);
        }
    #endregion

    #region NÃO CRIA MUNICIPIO SEM O NOME DO MUNICIPIO
        [Fact(DisplayName = "Não Cria Municipio Sem O Nome do Municpio")]
        public void Criar_Municipio_NaoCriarMunicipioSemNomeMunicipio()
        {
            var municipio = Assert.Throws<DomainExceptionValidation>(()=> new MunicipioEntity(1,"",1));
            Assert.Equal("O Municipio é obrigatório",municipio.Message);
        }
    #endregion

    #region NÃO CRIA MUNICIPIO SEM O ID DA PROVINCIA
        [Fact(DisplayName = "Não Cria Municipio Sem O ID da Provincia")]
        public void Criar_Municipio_NaoCriarMunicipioSemProvinciaID()
        {
            var municipio = Assert.Throws<DomainExceptionValidation>(()=> new MunicipioEntity(1,"Test",0));
            Assert.Equal("O ID da Provincia deve ser positivo",municipio.Message);
        }
    #endregion

    #region CRIA MUNICIPIO SEM O ID DO MUNICIPIO
        [Fact(DisplayName = "Cria Municipio Sem O ID do Municipio")]
        public void Criar_Municipio_CriarMunicipioSemID()
        {
            var municipio = new MunicipioEntity("Test",1);
            Assert.NotNull(municipio);
        }
    #endregion

    #region CRIA MUNICIPIO COM O ID DO MUNICIPIO
        [Fact(DisplayName = "Cria Municipio Com O ID do Municipio")]
        public void Criar_Municipio_CriarMunicipioComID()
        {
            var municipio = new MunicipioEntity(1,"Test",1);
            Assert.NotNull(municipio);
        }
    #endregion

    #region EDITAR MUNICIPIO SEM O ID DO MUNICIPIO
        [Fact(DisplayName = "Editar Municipio Sem O ID do Municipio")]
        public void Editar_Municipio_CriarMunicipioSemID()
        {
            var municipio = new MunicipioEntity("Test",1);
            municipio.Update("Test1",2);
            Assert.Equal("Test1", municipio.Municipio);
            Assert.Equal(2,municipio.ProvinciaId);
        }
    #endregion

    #region EDITAR MUNICIPIO SEM O ID DO MUNICIPIO
        [Fact(DisplayName = "Editar Municipio Com O ID do Municipio")]
        public void Editar_Municipio_CriarMunicipioCommID()
        {
            var municipio = new MunicipioEntity(1,"Test",1);
            municipio.Update("Test1",2);
            Assert.Equal("Test1", municipio.Municipio);
            Assert.Equal(2,municipio.ProvinciaId);
        }
    #endregion

}
