// <copyright file="npc_dota_hero_drow_ranger.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.Abilities.npc_dota_hero_drow_ranger
{
    using System;
    using System.ComponentModel.Composition;

    using Ensage.SDK.Service;

    [Export(typeof(npc_dota_hero_drow_ranger))]
    public class npc_dota_hero_drow_ranger
    {
        [ImportingConstructor]
        public npc_dota_hero_drow_ranger([Import] IServiceContext context)
        {
            this.Owner = (Hero)context.Owner;

            if (this.Owner.HeroId != HeroId.npc_dota_hero_drow_ranger)
            {
                throw new ArgumentException($"Invalid Context {this.Owner} for {nameof(npc_dota_hero_drow_ranger)}");
            }
        }

        [Import]
        public drow_ranger_frost_arrows FrostArrows { get; protected set; }

        [Import]
        public drow_ranger_marksmanship Marksmanship { get; protected set; }

        public Hero Owner { get; }

        [Import]
        public drow_ranger_trueshot Trueshot { get; protected set; }

        [Import]
        public drow_ranger_wave_of_silence WaveOfSilence { get; protected set; }
    }
}