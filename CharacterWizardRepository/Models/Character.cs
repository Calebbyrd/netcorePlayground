using System.Collections.Generic;

namespace CharacterWizardRepository.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public int PlayerId { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public string Outline { get; set; }
        public string Flaws { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Race { get; set; }
        public CharacterClass Class { get; set; }
        public Alignment Alignment { get; set; }
        public int Proficiency { get; set; } = 2;
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public int MaxHitPoints { get; set; }
        public string HitDice { get; set; }
        public int PassivePerception { get; set; }
        public List<AbilityScore> AbilityScores { get; set; } = new List<AbilityScore>();
        public List<Skills> Skills { get; set; } = new List<Skills>();
    }
}

