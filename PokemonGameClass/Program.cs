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

// (Steg 4) Create a new pokemon 

void RemovePokemon()
{
    Console.WriteLine();
    Console.WriteLine("Which pokemon do you want to remove?");
    Console.Write("Pokemon no: ");
    int response = Convert.ToInt32(Console.ReadLine());
}

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

string EvaluateRespons(string response)
{
    bool isAvaible = false;

    if (response == "Add")
    {
        //Lägg till pokemon
        Createpokemon();
        //var lastPokemon = pokemons[pokemons.Count - 1].GetNamn;
        //Console.WriteLine();
        //Console.WriteLine("Du har lagd:" + lastPokemon);
      
    }
    else if (response.ToLower() == "Remove")
    {
        //Remove pokemon
        RemovePokemon();
    }
    else if (response.ToLower() == "Display")
    {
        //Display pokemon
    }
    else if (response.ToLower() == "Evolva")
    {
        //Evolva Pokemon
    }
    else
        Console.WriteLine(" Fel inmattad ");
    return response;
}

// (Steg3) Ask user if wants to add/ remove / display / evolve 
void AskUser()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Add/ Remove/ Display/ Evolve");

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
        Console.WriteLine($"{pokemon.GetNamn()} -Type:  {pokemon.GetType()} -Evolution: {pokemon.GetCurrentForm()}/{pokemon.GetTotalForm()}");

        pokemonNumber++;
    }
}

//  (Steg1) Lägg till några pokemons från början
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



