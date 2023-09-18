using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_proj.Models;

namespace Tutorial_proj.Services.CharacterService
{
    public class CharacterService : ICharacterSevice
    {
        public List<Character> characters = new List<Character>{
            new Character(),
            new Character{ Id =1, Name = "Sam"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public Task<Character> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);

            if(character is not null){
                return character;
            }

            throw new Exception("Character not found !");
        }
    }
}