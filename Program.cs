﻿using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>();
        animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
        animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
        animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
        animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
        animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

        var animalesFiltrados = animales.Where(a => a.Color == "Verde" && IsVowel(a.Nombre[0]));

        foreach (var animal in animalesFiltrados)
        {
            Console.WriteLine($"{animal.Nombre} - {animal.Color}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("BRAYAM EDWIN QUISPE APAZA");
            Console.WriteLine("----------------------------");
        }
    }

    public static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) != -1;
    }

    public class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
    }
}
