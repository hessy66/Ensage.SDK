// <copyright file="DrowRanger.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_drow_ranger
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_drow_ranger)]
    public class DrowRanger : IHeroComponent
    {
        [ImportingConstructor]
        public DrowRanger([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public DrowRanger(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FrostArrows = new DrowRangerFrostArrows(context);
            this.Silence = new DrowRangerSilence(context);
            this.Trueshot = new DrowRangerTrueshot(context);
            this.Marksmanship = new DrowRangerMarksmanship(context);
            this.WaveOfSilence = new DrowRangerWaveOfSilence(context);
        }

        public DrowRangerFrostArrows FrostArrows { get; }

        public IHeroComponent Hero { get; }

        public DrowRangerMarksmanship Marksmanship { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DrowRangerSilence Silence { get; }

        public DrowRangerTrueshot Trueshot { get; }

        public DrowRangerWaveOfSilence WaveOfSilence { get; }
    }
}