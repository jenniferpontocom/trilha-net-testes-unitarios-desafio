using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista() // EXEMPLO
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista() // EXEMPLO
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //FEITO: Implementar método de teste


        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.False(resultado);
    }

    //FEITO: Corrigir a anotação [Fact]

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        // FEITO: Implementar método de teste


        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        var numeroParaMultiplicar = 2;
        
        // Act
        var resultado = _validacoes.MultiplicarNumerosLista(lista, numeroParaMultiplicar);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //FEITO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var maiorNumeroLista = 9;

        // Act
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //FEITO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(maiorNumeroLista, resultado);

    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //FEITO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var menorNumeroLista = -8;

        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //FEITO: Corrigir o Assert.Equal com base no retorno da chamada ao método
        Assert.Equal(menorNumeroLista, resultado);
    }
}
