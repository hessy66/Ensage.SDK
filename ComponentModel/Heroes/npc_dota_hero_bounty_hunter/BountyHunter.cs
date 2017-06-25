// <copyright file="BountyHunter.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bounty_hunter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_bounty_hunter)]
    public class BountyHunter : IHeroComponent
    {
        [ImportingConstructor]
        public BountyHunter([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public BountyHunter(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ShurikenToss = new BountyHunterShurikenToss(context);
            this.Jinada = new BountyHunterJinada(context);
            this.WindWalk = new BountyHunterWindWalk(context);
            this.Track = new BountyHunterTrack(context);
        }

        public IHeroComponent Hero { get; }

        public BountyHunterJinada Jinada { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BountyHunterShurikenToss ShurikenToss { get; }

        public BountyHunterTrack Track { get; }

        public BountyHunterWindWalk WindWalk { get; }
    }
}