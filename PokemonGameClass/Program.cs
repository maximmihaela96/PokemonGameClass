//Simple CRUD app

//Skapa en lista med pokemons
//Displaya listan med pokemons
//Fråga användaren om den vill lägga till-tabort-displaya

//Lägga till
//Fråga användaren om pokemonnamn
//Fråga användaren om pokemon type
//Fråga användaren om max form
//Skapa ett nytt pokemon objekt (klass) med användarens info
// Displaya listan med pokemons

//Ta bort
//Fråga användaren om vilken pokemon den vill ta bort
//Hitta rätt pokemon i listan och
//Ta bort den
//Displaya listan med pokemon

//Displaya
//Displaya listan med pokemons

//Evolva 
//Fråga användaren om vilken pokemon vill evolva
//Hitta rätt pokemon i listan
//Evolva den pokemon genom en metod i dess klass
//Displaya listan med pokemons

using PokemonGameClass;

//Create listan med pokemons
List<Pokemon> pokemons = new();

//Anropa metoderna
PopulatePokemonsList();
DisplayPokemons();
AskUser();

//Methoder

// (Steg 7) Increse the current form of a Pokemon
void EvolvPokemon()
{
    Console.WriteLine();
    Console.WriteLine("Witch pokemon do you want to evolv?");
    Console.WriteLine("Pokemon nummber:");
    int pokemoNumber = Convert.ToInt32(Console.ReadLine());

    if(pokemoNumber <= pokemons.Count() && pokemoNumber > 0)
    {
        //Find the corect Pokemon
        //Run the Evolve method on that pokemon

        //verifiera om maxform är redan nått
        int pokemonIndex = pokemoNumber - 1;
        if (pokemons[pokemonIndex].GetCurrentForm() < pokemons[pokemonIndex].GetTotalForm())
        {
    
            pokemons[pokemonIndex].Evolv();
        }
        else
        {
            Console.WriteLine("Pokemonen är redan max evolverad");
        }
    }
    DisplayPokemons();
    AskUser();
}

// (Steg 6) Ta bort pokemon from lista
void RemovePokemon()
{
    Console.WriteLine();
    Console.WriteLine("Which pokemon do you want to remove?");
    Console.Write("Pokemon name: ");
    int pokemonNumber = Convert.ToInt32(Console.ReadLine());
    //string pokemonName = Console.ReadLine();

    if (pokemonNumber <= pokemons.Count())
     {
         //Remove the pokemon
         int pokemonIndex = pokemonNumber - 1;
        //pokemons.RemoveAt(pokemonIndex);
        pokemons.Remove(pokemons[pokemonIndex]);
        Console.WriteLine("Pokemon is removed!");
        DisplayPokemons();
        AskUser();
     }
     else
     {
         //Ask user for another pokemon number
         Console.WriteLine("Number doesn't exist!");
     }
    

 /*   foreach (Pokemon pokemon in pokemons)
    {
        if (pokemon.GetNamn().ToLower() == pokemonName.ToLower())
        {
            Pokemon pokemonToRemove = pokemon;
        }
    }
 */
}

// (Steg 5) Create a new pokemon 
void Createpokemon()
    {
        Console.WriteLine();
        Console.WriteLine(" What should be the pokemon name ? ");
        Console.WriteLine("Name: ");
        string newPokemonNamn = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(" What should be the pokemon type ? ");
        Console.WriteLine("Type: ");
        string newPokemonTYPE = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(" What should be the pokemon maxForm ? ");
        Console.WriteLine("MaxForm: ");
        int newPokemonMaxForm = Convert.ToInt32(Console.ReadLine());

        //Create Constructor, skappa pokemon
        Pokemon newPokemon = new(newPokemonNamn, newPokemonTYPE, newPokemonMaxForm);

        pokemons.Add(newPokemon);
        DisplayPokemons();
    }

// (Steg 4) Verifiera anvendarens respons
string EvaluateRespons(string response)
    {
        //bool isAvaible = false;

        if (response.ToLower() == "add")
        {
        //Lägg till pokemon
        //var lastPokemon = pokemons[pokemons.Count - 1].GetNamn;
        //Console.WriteLine();
        //Console.WriteLine("Du har lagd:" + lastPokemon);
            Createpokemon();

    }
        else if (response.ToLower() == "remove")
        {
            //Remove pokemon
            RemovePokemon();
        }
        else if (response.ToLower() == "display")
        {
            //Display pokemon
            DisplayPokemons();
            AskUser();
        }
        else if (response.ToLower() == "evolva")
        {
            //Evolva Pokemon
            EvolvPokemon();
         
        }
        else
        {
            Console.WriteLine(" Fel inmattad ");
        }
           
        return response;
    }

// (Steg3) Ask user if wants to add/ remove / display / evolve 
void AskUser()
    {
        Console.WriteLine();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("Add/ Remove/ Display/ Evolva");

        Console.Write("Replay:");
        string respons = Console.ReadLine();
        EvaluateRespons(respons);
    }

// (Steg2) Loop som displaya listan med pokemons 
void DisplayPokemons()
    {
        Console.Clear();
        int pokemonNumber = 1;
        foreach (Pokemon pokemon in pokemons)
        {

            //Console.WriteLine(pokemon.GetNamn() + " - " + pokemon.GetType());
            Console.WriteLine($"{pokemonNumber}. {pokemon.GetNamn()} -Type:  {pokemon.GetType()} -Evolution: {pokemon.GetCurrentForm()}/{pokemon.GetTotalForm()}");

            pokemonNumber++;
        }
    }

// (Steg1) Lägg till några pokemons från början
void PopulatePokemonsList()

    {
        //Skappa instans
        Pokemon pokemon1 = new("Charmander", "Fire", 3);
        pokemons.Add(pokemon1);

        Pokemon pokemon2 = new("Squirtle", "Water", 3);
        pokemons.Add(pokemon2);

        Pokemon pokemon3 = new("Bulbasar", "Poison", 3);
        pokemons.Add(pokemon3);

        Pokemon pokemon4 = new("Pikachu", "Electric", 2);
        pokemons.Add(pokemon4);

    }




