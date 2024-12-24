using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeiaJa.UnitTests.BackOffice.Domain.Entities
{
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
    }
}