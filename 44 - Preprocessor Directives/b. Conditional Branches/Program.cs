// Copyright © 2026 Rick Beerendonk

// Run with -p:DefineConstants=NETHERLANDS or -p:DefineConstants=NORWAY.
#if NETHERLANDS
Console.WriteLine("Amsterdam");
#elif NORWAY
Console.WriteLine("Oslo");
#else
Console.WriteLine("No market selected");
#endif
