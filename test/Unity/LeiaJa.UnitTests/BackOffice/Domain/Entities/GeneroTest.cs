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
}
