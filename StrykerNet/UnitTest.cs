using BusinessClass;
using FluentAssertions;
using Xunit;

namespace StrykerNet
{
    public class UnitTest
    {
        [Fact]
        public void Deve_identificar_que_a_pessoa_esta_na_faixa_de_risco()
        {
            new FaixaEtaria().FaixaRisco(idade: 20).Should().BeTrue();
        }

        [Fact]
        public void Deve_identificar_que_a_pessoa_esta_fora_da_faixa_de_risco()
        {
            new FaixaEtaria().FaixaRisco(idade: 15).Should().BeFalse();
        }

        [Theory]
        [InlineData(18)]
        [InlineData(25)]
        [InlineData(35)]
        public void Deve_identificar_que_a_pessoa_esta_na_faixa_de_risco_v2(int idade)
        {
            new FaixaEtaria().FaixaRisco(idade).Should().BeTrue();
        }

        [Theory]
        [InlineData(17)]
        [InlineData(36)]
        public void Deve_identificar_que_a_pessoa_esta_fora_da_faixa_de_risco_v2(int idade)
        {
            new FaixaEtaria().FaixaRisco(idade).Should().BeFalse();
        }
    }
}
