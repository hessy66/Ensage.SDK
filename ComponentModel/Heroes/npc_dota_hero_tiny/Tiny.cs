// <copyright file="Tiny.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tiny
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_tiny)]
    public class Tiny : IHeroComponent
    {
        [ImportingConstructor]
        public Tiny([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Tiny(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Avalanche = new TinyAvalanche(context);
            this.Toss = new TinyToss(context);
            this.CraggyExterior = new TinyCraggyExterior(context);
            this.Grow = new TinyGrow(context);
        }

        public TinyAvalanche Avalanche { get; }

        public TinyCraggyExterior CraggyExterior { get; }

        public TinyGrow Grow { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TinyToss Toss { get; }
    }
}