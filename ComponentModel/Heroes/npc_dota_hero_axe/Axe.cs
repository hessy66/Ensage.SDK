// <copyright file="Axe.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_axe
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_axe)]
    public class Axe : IHeroComponent
    {
        [ImportingConstructor]
        public Axe([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Axe(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BerserkersCall = new AxeBerserkersCall(context);
            this.BattleHunger = new AxeBattleHunger(context);
            this.CounterHelix = new AxeCounterHelix(context);
            this.CullingBlade = new AxeCullingBlade(context);
        }

        public AxeBattleHunger BattleHunger { get; }

        public AxeBerserkersCall BerserkersCall { get; }

        public AxeCounterHelix CounterHelix { get; }

        public AxeCullingBlade CullingBlade { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}