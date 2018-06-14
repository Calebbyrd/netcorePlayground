using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterWizardRepository.Models;

namespace CharacterWizardRepository
{
    public class CharWizRepo
    {
        private List<Player> _players = new List<Player>
        {
            new Player
            {
                PlayerId = 1,
                PlayerName = "Caleb"
            },
            new Player
            {
                PlayerId = 2,
                PlayerName = "Jason"
            }
        };

        private List<Character> _characters = new List<Character>
        {
            new Character
            {
                CharacterName = "Caleb Orc",
                PlayerId = 1,
                Level = 1,
                Race = "Half-Orc",
                Class = new CharacterClass {ClassName = "Berserker"},
                Alignment = Alignment.LawfulNeutral,
                Proficiency = 2,
                ArmorClass = 12,
                Speed = 30,
                MaxHitPoints = 8,
                HitDice = "1d8",
                PassivePerception = 12,
                AbilityScores = new List<AbilityScore>
                {
                    new AbilityScore {Ability = Ability.Strength, Score = 14},
                    new AbilityScore {Ability = Ability.Dexterity, Score = 10},
                    new AbilityScore {Ability = Ability.Constitution, Score = 16},
                    new AbilityScore {Ability = Ability.Intelligence, Score = 8},
                    new AbilityScore {Ability = Ability.Wisdom, Score = 13},
                    new AbilityScore {Ability = Ability.Charisma, Score = 6},
                },
                Skills = new List<Skills>
                {
                    new Skills {Skill = Skill.Athletics, HasProficiency = true},
                    new Skills {Skill = Skill.AnimalHandling, HasProficiency = true}
                }
            },
            new Character
            {
                CharacterName = "Jason Elf",
                PlayerId = 2,
                Level = 1,
                Race = "Half-Elf",
                Class = new CharacterClass {ClassName = "Mage"},
                Alignment = Alignment.LawfulGood,
                Proficiency = 2,
                ArmorClass = 16,
                Speed = 30,
                MaxHitPoints = 5,
                HitDice = "1d6",
                PassivePerception = 15,
                AbilityScores = new List<AbilityScore>
                {
                    new AbilityScore {Ability = Ability.Strength, Score = 6},
                    new AbilityScore {Ability = Ability.Dexterity, Score = 9},
                    new AbilityScore {Ability = Ability.Constitution, Score = 11},
                    new AbilityScore {Ability = Ability.Intelligence, Score = 16},
                    new AbilityScore {Ability = Ability.Wisdom, Score = 13},
                    new AbilityScore {Ability = Ability.Charisma, Score = 12},
                },
                Skills = new List<Skills>
                {
                    new Skills {Skill = Skill.Insight, HasProficiency = true},
                    new Skills {Skill = Skill.Perception, HasProficiency = true}
                }
            }
        };

        public Player GetPlayer(int playerId)
        {
            return _players.FirstOrDefault(m => m.PlayerId == playerId);
        }
        public List<Player> GetPlayers()
        {
            return _players;
        }
        public List<Character> GetPlayerCharacterList(int playerId)
        {
            return _characters.Where(m => m.PlayerId == playerId).ToList();
        }

        public Character GetCharacter(int characterId)
        {
            return _characters.FirstOrDefault(m => m.CharacterId == characterId);
        }

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public void UpdateCharacter(Character character)
        {
            var toUpdate = _characters.FirstOrDefault(m => m.CharacterId == character.CharacterId);
            var index = _characters.IndexOf(toUpdate);
            if (index != -1)
                _characters[index] = character;
        }
}
}
