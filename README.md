# Пример настройки анализатора StyleCop в новых проектах VS
## Disclaimer
Данный пример является сугубо частным мнением. Пример предоставляется как есть (`as-is`). Автор не несёт ответственности за последствия использования данного примера. Использование данного примера в своих проектах осуществляется на свой страх и риск.

## TL;DR
Для того, чтобы подключить и начать использовать новую версию анализатора StyleCop (на основе Roslyn) необходимо добавить в целевой `*.csproj` файл следующие инструкции

1. Путь к файлу целевого набора правил (в данном случае для проектов модульных тестов)
```xml
  <PropertyGroup>
    <!-- ... -->

    <CodeAnalysisRuleSet>$(SolutionDir)_stylecop\tests.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
```

2. Включение файлов в состав решения (`*.sln`) посредством указания ссылки (`Link="..."`)
```xml
  <ItemGroup>
    <AdditionalFiles Include="$(SolutionDir)_stylecop\stylecop.json" Link="_stylecop\stylecop.json" />
    <AdditionalFiles Include="$(SolutionDir)_stylecop\tests.ruleset" Link="_stylecop\tests.ruleset" />
  </ItemGroup>
```

3. Указание используемого nuget-пакета

```xml
  <ItemGroup>
     <!-- ... -->

    <PackageReference Include="StyleCop.Analyzers" Version="1.1.118">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
  </ItemGroup>
```