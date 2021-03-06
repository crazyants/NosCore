﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NosCore.Shared.Buff;

namespace NosCore.Data.StaticEntities
{
    public class CardDTO : IDTO
    {
        [Key]
        public short CardId { get; set; }

        public int Duration { get; set; }

        public int EffectId { get; set; }

        public byte Level { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public int Delay { get; set; }

        public short TimeoutBuff { get; set; }

        public byte TimeoutBuffChance { get; set; }

        public BCardType.CardType BuffType { get; set; }

        public byte Propability { get; set; }

        public ICollection<BCardDTO> BCards { get; set; }
    }
}
