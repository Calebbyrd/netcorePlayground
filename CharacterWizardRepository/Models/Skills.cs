namespace CharacterWizardRepository.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public Skill Skill { get; set; }
        public bool HasProficiency { get; set; }
        public bool HasExpertise { get; set; }
        public bool HasBonus { get; set; }
        public int Bonus { get; set; }
    }
}