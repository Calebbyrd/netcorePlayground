using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterWizardRepository.Models;

namespace CharacterWizard.Models
{
    public class CharacterSheetVm
    {
        public Player Player { get; set; }
        public Character Character { get; set; }
        public Skills SkillList { get; set; }
        public Alignment Alignments { get; set; }
        public Ability Abilities { get; set; }
    }
}
