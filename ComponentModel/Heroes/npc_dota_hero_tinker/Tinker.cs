// <copyright file="Tinker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tinker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_tinker)]
    public class Tinker : IHeroComponent
    {
        [ImportingConstructor]
        public Tinker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Tinker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Laser = new TinkerLaser(context);
            this.HeatSeekingMissile = new TinkerHeatSeekingMissile(context);
            this.MarchOfTheMachines = new TinkerMarchOfTheMachines(context);
            this.Rearm = new TinkerRearm(context);
        }

        public TinkerHeatSeekingMissile HeatSeekingMissile { get; }

        public IHeroComponent Hero { get; }

        public TinkerLaser Laser { get; }

        public TinkerMarchOfTheMachines MarchOfTheMachines { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TinkerRearm Rearm { get; }
    }
}