# stryker-net-demo
Testes de Mutação com Stryker.NET

Para instalar globalmente o [Stryker para .NET Core](https://stryker-mutator.io/stryker-net/), basta rodar:

`dotnet tool install -g dotnet-stryker`

Para instalar localmente o [Stryker para .NET Core](https://stryker-mutator.io/stryker-net/), basta rodar:

`dotnet tool install --local dotnet-stryker`

Depois, navege para a pasta `StrykerNet` e rode o comando `dotnet stryker --project-file=<Your path>\stryker-net-demo\BusinessClass\BusinessClass.csproj`.

![Exemplo da execução do Stryker no bash](/imgs/stryker-console.png)