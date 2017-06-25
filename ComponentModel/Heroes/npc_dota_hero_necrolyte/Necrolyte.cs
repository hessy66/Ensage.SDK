// <copyright file="Necrolyte.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_necrolyte
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_necrolyte)]
    public class Necrolyte : IHeroComponent
    {
        [ImportingConstructor]
        public Necrolyte([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Necrolyte(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.DeathPulse = new NecrolyteDeathPulse(context);
            this.HeartstopperAura = new NecrolyteHeartstopperAura(context);
            this.Sadist = new NecrolyteSadist(context);
            this.ReapersScythe = new NecrolyteReapersScythe(context);
            this.SadistStop = new NecrolyteSadistStop(context);
        }

        public NecrolyteDeathPulse DeathPulse { get; }

        public NecrolyteHeartstopperAura HeartstopperAura { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public NecrolyteReapersScythe ReapersScythe { get; }

        public NecrolyteSadist Sadist { get; }

        public NecrolyteSadistStop SadistStop { get; }
    }
}