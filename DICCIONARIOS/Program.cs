
Dictionary<int, string> diccionario = new Dictionary<int, string>()
{
    {0, "Juan Perez" },
    {1, "Maria Lopez" },
    {2, "Pedro Gonzalez" },
    {3, "Ana Torres" },
    {4, "Luis Martinez" },
    {5, "Laura Sanchez" },
    {6, "Carlos Ramirez" },
    {7, "Sofia Morales" },
    {8, "Javier Jimenez" },
    {9, "Isabel Castro" }
};
diccionario.Add(10, "Fernando Ruiz");

//diccionario.Remove(2);

//Console.WriteLine(diccionario.ContainsValue("Sofia Morales"));

Console.WriteLine($"Cantidad de Elementos: {diccionario.Count}");

//Console.WriteLine(diccionario.TryGetValue(3, out string stsError));

diccionario.Clear();

foreach (var d in diccionario)
    {
        Console.WriteLine($"Key: {d.Key}, Value: {d.Value}");
    }
