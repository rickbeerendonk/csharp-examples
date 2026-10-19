# Comments

Single line:

```csharp
// One line
```

Multiline:

```csharp
/*
Multi
line
*/
```

Single line in multiline:

```csharp
/*
Multi
  // Nested line
*/
```

## XML Documentation

Use `///` comments on types and members for XML documentation and IntelliSense.
See the documented class and method in [Program.cs](./Program.cs).

To generate and validate the XML documentation:

```zsh
dotnet build -p:GenerateDocumentationFile=true
```

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2022 Rick Beerendonk
