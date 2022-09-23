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
EvaluateRespons(response);

string EvaluateRespons(string response)
{
    bool isAvaible = false;

    if (response.ToLower() == "Add")
    {
        //Lägg till pokemon
    }
    else if (response.ToLower() == "Remove")
    {
        //Remove pokemon
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
}

//Methoder

// (Steg2) Loop som displaya listan med pokemons 
void DisplayPokemons()
{
   foreach(Pokemon pokemon in pokemons)
    {
        //Console.WriteLine(pokemon.GetNamn() + " - " + pokemon.GetType());
        Console.WriteLine($"{pokemon.GetNamn()} -Type:  {pokemon.GetType()} -Evolution: {pokemon.GetCurrentForm()}/{pokemon.GetTotalForm()}");
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



