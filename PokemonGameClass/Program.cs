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

List<Pokemon> pokemons = new();
PopulatePokemonsList();

//Method

//Lägg till några pokemons från början
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