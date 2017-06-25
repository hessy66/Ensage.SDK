// <copyright file="Huskar.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_huskar
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_huskar)]
    public class Huskar : IHeroComponent
    {
        [ImportingConstructor]
        public Huskar([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Huskar(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.InnerVitality = new HuskarInnerVitality(context);
            this.BurningSpear = new HuskarBurningSpear(context);
            this.BerserkersBlood = new HuskarBerserkersBlood(context);
            this.LifeBreak = new HuskarLifeBreak(context);
        }

        public HuskarBerserkersBlood BerserkersBlood { get; }

        public HuskarBurningSpear BurningSpear { get; }

        public IHeroComponent Hero { get; }

        public HuskarInnerVitality InnerVitality { get; }

        public HuskarLifeBreak LifeBreak { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}