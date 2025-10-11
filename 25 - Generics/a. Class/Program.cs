// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var stringCache = new Cache<string>();
stringCache.SetByKey("greeting", "Hello");
Console.WriteLine(stringCache.GetByKey("greeting"));

var intCache = new Cache<int>();
intCache.SetByKey("year", 2025);
Console.WriteLine(intCache.GetByKey("year"));

// Hello
// 2025

public class Cache<T>
{
    private readonly Dictionary<string, T> _store = new Dictionary<string, T>();
    
    public T? GetByKey(string key) => _store.TryGetValue(key, out T? value) ? value : default(T);
    
    public void SetByKey(string key, T value) => _store[key] = value;
}

