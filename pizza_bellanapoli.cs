using System;

class BellaNapoli
{
    static void Main()
    {
        // Saludar
        Console.WriteLine("🍕 ¡Bienvenido a Bella Napoli!");
        Console.WriteLine("Simulador de Pedidos Interactivo\n");

        // aqui el programaa pregunta el tipo de pizza
        Console.WriteLine("¿Deseas una pizza vegetariana?");
        Console.WriteLine("1. Sí (Vegetariana)");
        Console.WriteLine("2. No (No Vegetariana)");
        Console.Write("Elige tu opción (1 o 2): ");
        
        string opcion = Console.ReadLine();
        
        // aqui se guardara las desiciones 
        string tipoPizza = "";
        string ingredienteAdicional = "";
        
        // dependiendo de la pizza que elijas se mostraran los ingredientes
        if (opcion == "1")
        {
            tipoPizza = "Vegetariana";
            Console.WriteLine("\n Elegiste: VEGETARIANA");
            Console.WriteLine("\nIngredientes Adicionales Disponibles:");
            Console.WriteLine("1. 🫑 Pimiento");
            Console.WriteLine("2.🧊 Tofu");
            Console.Write("\nElige un ingrediente (1 o 2): ");
            
            string eleccion = Console.ReadLine();
            
            if (eleccion == "1")
                ingredienteAdicional = "Pimiento";
            else if (eleccion == "2")
                ingredienteAdicional = "Tofu";
            else
                ingredienteAdicional = "No seleccionado";
        }
        else if (opcion == "2")
        {
            tipoPizza = "No Vegetariana";
            Console.WriteLine("\n✅ Elegiste: NO VEGETARIANA");
            Console.WriteLine("\nIngredientes Adicionales Disponibles:");
            Console.WriteLine("1. 🍕 Peperoni");
            Console.WriteLine("2. 🍖 Jamón");
            Console.WriteLine("3. 🐟 Salmón");
            Console.Write("\nElige un ingrediente (1, 2 o 3): ");
            
            string eleccion = Console.ReadLine();
            
            if (eleccion == "1")
                ingredienteAdicional = "Peperoni";
            else if (eleccion == "2")
                ingredienteAdicional = "Jamón";
            else if (eleccion == "3")
                ingredienteAdicional = "Salmón";
            else
                ingredienteAdicional = "No seleccionado";
        }
        else
        {
            Console.WriteLine("❌ Opción no válida");
            return; // saalida delprogram
        }

        //siguiente paso ultima pantalla:------------ Mostrar resumen final--------------//
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("📋 resumen de tu pedido");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine($"Tipo de pizza: {tipoPizza}");
        Console.WriteLine($"Ingredientes: Tomate, Mozzarella, {ingredienteAdicional}");
        Console.WriteLine(new string('=', 50));
        Console.WriteLine("¡Gracias por tu pedido! 🍕");
    }
}