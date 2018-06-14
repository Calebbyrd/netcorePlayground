namespace CharacterWizardRepository.Models
{
    public class AbilityScore
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public Ability Ability { get; set; }
        public int Score { get; set; }
        public bool HasBonus { get; set; }
        public int Bonus { get; set; }
    }
}