using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();   
        }
        

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void Damage()
        {

            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                if (Pokemons[i].Health - 10 <= 0)
                {
                    this.Pokemons.Remove(this.Pokemons[i]);
                    i--;
                }
                else
                {
                    Pokemons[i].Health -= 10;
                }
                
            }
        }

        public void BadgeReward()
        {
            this.Badges++;
        }
    }
}
