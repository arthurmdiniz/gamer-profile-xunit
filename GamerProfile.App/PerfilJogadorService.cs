namespace GamerProfile.App;

public class PerfilJogadorService
{
	public string GerarTagUsuario(string nickname, int codigo)
	{
		return $"{nickname}#{codigo:D4}";
	}

	public string GerarTagUsuario(string nickname, string codigo)
	{
		return $"{nickname}#{codigo}";
	}

	public int CalcularXPTotal(int xpFase1, int xpFase2)
	{
		return xpFase1 + xpFase2 + 100;
	}

	public bool PodeJogarPartidaRanqueada(int nivelJogador)
	{
		return nivelJogador >= 15;
	}

	public bool EEligivelParaRanked(int nivelJogador)
	{
		return PodeJogarPartidaRanqueada(nivelJogador);
	}
}
