using System;
using System.Collections.Generic;
class BellaNapoli
{
    static void Main()
    {
        Console.WriteLine("🍕 ¡Bienvenido a Bella Napoli!");
        Console.WriteLine("Simulador de Pedidos Interactivo\n");
        
        // Aca creo dos listas, una para vegetarianos y otra para los que comen de todo jajaja
        List<string> ingredientesVegetarianos = new List<string> { "Pimiento", "Tofu" };
        List<string> ingredientesNoVegetarianos = new List<string> { "Peperoni", "Jamon", "salmon" };
        
        // Pregunta de inicio del programma Al cliente 
        Console.WriteLine("¿Deseas una pizza vegetariana?");
        Console.WriteLine("1. Si (Vegetariana)");
        Console.WriteLine("2. No (No Vegetariana)");
        Console.Write("Elige tu opcion (1 o 2): ");
        
        string opcion = Console.ReadLine();
        
        string tipoPizza = "";
        string ingredienteAdicional = "";
        
        // Aca entra en la logica, si elige 1 muestra los vegetarianos
        if (opcion == "1")
        {
            tipoPizza = "Vegetariana";
            Console.WriteLine("\n✅ Elegiste: VEGETARIANA");
            Console.WriteLine("\nIngredientes Adicionales Disponibles:");
            
            // Recorro la lista y muestro cada ingrediente con su numero
            for (int i = 0; i < ingredientesVegetarianos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredientesVegetarianos[i]}");
            }
            
            Console.Write("\nElige un ingrediente: ");
            string eleccion = Console.ReadLine();
            
            // Aca valido que lo que puso sea un numero valido y que este en el rango
            if (int.TryParse(eleccion, out int indice) && indice > 0 && indice <= ingredientesVegetarianos.Count)
                ingredienteAdicional = ingredientesVegetarianos[indice - 1];
            else
                ingredienteAdicional = "No seleccionado";
        }
        else if (opcion == "2")
        {
            tipoPizza = "No Vegetariana";
            Console.WriteLine("\n✅ Elegiste: NO VEGETARIANA");
            Console.WriteLine("\nIngredientes Adicionales Disponibles:");
            
            // Misma logica pero ahora con los ingredientes de carne
            for (int i = 0; i < ingredientesNoVegetarianos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ingredientesNoVegetarianos[i]}");
            }
            
            Console.Write("\nElige un ingrediente: ");
            string eleccion = Console.ReadLine();
            
            if (int.TryParse(eleccion, out int indice) && indice > 0 && indice <= ingredientesNoVegetarianos.Count)
                ingredienteAdicional = ingredientesNoVegetarianos[indice - 1];
            else
                ingredienteAdicional = "No seleccionado";
        }
        else
        {
            Console.WriteLine("❌ Opcion no valida");
            return;
        }
        
        // Aca va el resumen final con todo lo que eligio el cliente
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("📋 Resumen de tu pedido");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine($"Tipo de pizza: {tipoPizza}");
        Console.WriteLine($"Ingredientes: Tomate, Mozzarella, {ingredienteAdicional}");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("¡Gracias por tu pedido! 🍕");
    }
}