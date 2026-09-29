using GamerProfile;
using Xunit;
using GamerProfile.App;

namespace GamerProfile.Tests;

public class PerfilJogadorServiceTests
{
	[Fact]
	public void GerarTagUsuario_DeveRetornarFormatoCorreto()
	{
		var service = new PerfilJogadorService();
		var resultado = service.GerarTagUsuario("Aragorn", 1042);

		Assert.Equal("Aragorn#1042", resultado);
	}

	[Fact]
	public void CalcularXPTotal_DeveSomarAplicandoOBonus()
	{
		var service = new PerfilJogadorService();
		var resultado = service.CalcularXPTotal(200, 300);

		Assert.Equal(600, resultado);
	}

	[Fact]
	public void PodeJogarPartidaRanqueada_DeveExigirNivel15()
	{
		var service = new PerfilJogadorService();
		var resultado = service.PodeJogarPartidaRanqueada(15);
		Assert.True(service.PodeJogarPartidaRanqueada(15));
		Assert.True(service.PodeJogarPartidaRanqueada(20));
		Assert.False(service.PodeJogarPartidaRanqueada(14));
		Assert.False(service.PodeJogarPartidaRanqueada(1));
	}
}
