// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var permissions = FilePermissions.Read | FilePermissions.Write;
Console.WriteLine(permissions);                           // Read, Write
Console.WriteLine((int)permissions);                      // 3

Console.WriteLine(permissions.HasFlag(FilePermissions.Read));    // True
Console.WriteLine(permissions.HasFlag(FilePermissions.Execute)); // False

var allPermissions = FilePermissions.All;
Console.WriteLine(allPermissions);                        // All
Console.WriteLine((int)allPermissions);                   // 7

[Flags]
enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    ReadWrite = Read | Write,
    All = Read | Write | Execute
}
