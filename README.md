# LibraryDesk

## Опис проєкту

**LibraryDesk** — консольний застосунок на C# для ведення каталогу бібліотеки та обліку видачі книжок читачам.

Програма дозволяє зберігати інформацію про книжки, читачів і документи видачі.

## Склад проєкту

Рішення складається з двох проєктів:

- **LibraryDesk.Core** — містить основні класи, доменні сутності та логіку роботи програми.
- **LibraryDesk.App** — консольний застосунок, який забезпечує взаємодію з користувачем.

## Технології та вимоги

- C#
- .NET 8
- Visual Studio Code
- C# Dev Kit
- Git
- StyleCop.Analyzers
- Roslyn Analyzers

## Структура проєкту

```text
LibraryDesk/
├── LibraryDesk.App/
│ └── Program.cs
├── LibraryDesk.Core/
│ ├── Book.cs
│ ├── Reader.cs
│ ├── Loan.cs
│ ├── LoanItem.cs
│ └── LoanStatus.cs
├── .editorconfig
├── .gitignore
├── Directory.Build.props
├── LibraryDesk.slnx
├── CODING_STANDARD.md
└── README.md
```

## Запуск проєкту

Для запуску необхідно відкрити термінал у кореневій папці проєкту та виконати команди по черзі:

```powershell
dotnet restore
dotnet build
dotnet run --project LibraryDesk.App
```

## Перевірка форматування та якості коду

Для перевірки форматування використовується команда:

```powershell
dotnet format --verify-no-changes
```

Для перевірки успішності компіляції використовується:

```powershell
dotnet build
```

## Стандарт кодування

Правила написання та оформлення програмного коду описані у файлі [CODING_STANDARD.md](CODING_STANDARD.md).

## Автор

Шереметьєв Ілля, група 472
