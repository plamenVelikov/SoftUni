using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string[] inputPoks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (inputPoks[0] != "Tournament")
            {
                string trainerName = inputPoks[0];
                string pokemonName = inputPoks[1];
                string pokElement = inputPoks[2];
                int pokHealth = int.Parse(inputPoks[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokElement, pokHealth);
                Trainer trainer = new Trainer(trainerName);
                if (!trainers.ContainsKey(trainerName))
                {

                    trainers.Add(trainerName, trainer);
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
                inputPoks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                string attElement = input[0];
                foreach (var trainer in trainers)
                {
                    if (!trainer.Value.Pokemons.Any(x => x.Element == attElement))
                    {
                        trainer.Value.Damage();
                    }
                    else
                    {
                        trainer.Value.BadgeReward();
                    }
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            var sorted = trainers.OrderByDescending(x => x.Value.Badges);
            foreach (var trainer in sorted)
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.Pokemons.Count()}");
            }
        }
    }
}
