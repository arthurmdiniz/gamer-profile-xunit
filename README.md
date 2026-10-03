# Gamer Profile xUnit

## Propósito

Este projeto demonstra um serviço simples de perfil de jogador em .NET, com testes unitários usando xUnit. A aplicação contém a classe `PerfilJogadorService`, responsável por gerar tags de usuário, calcular XP total e verificar a elegibilidade para partidas ranqueadas.

## Testes unitários

O projeto `GamerProfile.Tests` contém três testes utilizando o atributo `[Fact]`:

1. **Geração de tag:** verifica se o nickname e o código são concatenados no formato `Nickname#0000`.
2. **Cálculo de XP:** verifica se o XP de duas fases é somado com o bônus fixo de 100 pontos. Por exemplo, `200 + 300 + 100 = 600`.
3. **Elegibilidade para ranqueada:** verifica se jogadores de nível maior ou igual a 15 são elegíveis e se jogadores abaixo do nível 15 não são.

## Como executar os testes

Pré-requisito: ter o SDK do .NET instalado.

Na raiz do repositório, execute:

```bash
dotnet test
```

O comando restaura as dependências, compila a solução e executa os testes do projeto `GamerProfile.Tests`. O resultado esperado é a aprovação dos três testes.

## Sobre o Autor

Ajustado e documentado por **Arthur Marques Diniz**.

*   **GitHub:** [@arthurmdiniz](https://github.com)
*   **LinkedIn:** [arthurmdiniz](https://www.linkedin.com/in/arthurmdiniz/)
*   **E-mail:** arthurmdiniz@outlook.com.br

Sinta-se à vontade para enviar *pull requests*, reportar problemas ou propor melhorias!