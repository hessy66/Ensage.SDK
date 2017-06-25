// <copyright file="Disruptor.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_disruptor
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_disruptor)]
    public class Disruptor : IHeroComponent
    {
        [ImportingConstructor]
        public Disruptor([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Disruptor(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ThunderStrike = new DisruptorThunderStrike(context);
            this.Glimpse = new DisruptorGlimpse(context);
            this.KineticField = new DisruptorKineticField(context);
            this.StaticStorm = new DisruptorStaticStorm(context);
        }

        public DisruptorGlimpse Glimpse { get; }

        public IHeroComponent Hero { get; }

        public DisruptorKineticField KineticField { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DisruptorStaticStorm StaticStorm { get; }

        public DisruptorThunderStrike ThunderStrike { get; }
    }
}