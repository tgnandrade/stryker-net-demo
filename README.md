# stryker-net-demo
Testes de Mutação com [Stryker.NET](https://stryker-mutator.io/stryker-net/)

Para instalar globalmente o [Stryker.NET](https://github.com/stryker-mutator/stryker-net), basta rodar:

`dotnet tool install -g dotnet-stryker`

Para instalar localmente o [Stryker.NET](https://github.com/stryker-mutator/stryker-net), basta rodar:

`dotnet tool install --local dotnet-stryker`

Para atualizar globalmente o [Stryker.NET](https://github.com/stryker-mutator/stryker-net), basta rodar:

`dotnet tool update --global dotnet-stryker`

Para atualizar localmente o [Stryker.NET](https://github.com/stryker-mutator/stryker-net), basta rodar:

`dotnet tool update --local dotnet-stryker`

Depois, navege para a pasta `StrykerNet` e rode o comando `dotnet stryker --project-file=<Your path>\stryker-net-demo\BusinessClass\BusinessClass.csproj`.

![Exemplo da execução do Stryker no bash](/imgs/stryker-console.png)