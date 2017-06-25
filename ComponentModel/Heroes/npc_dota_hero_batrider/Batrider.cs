// <copyright file="Batrider.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_batrider
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_batrider)]
    public class Batrider : IHeroComponent
    {
        [ImportingConstructor]
        public Batrider([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Batrider(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.StickyNapalm = new BatriderStickyNapalm(context);
            this.Flamebreak = new BatriderFlamebreak(context);
            this.Firefly = new BatriderFirefly(context);
            this.FlamingLasso = new BatriderFlamingLasso(context);
        }

        public BatriderFirefly Firefly { get; }

        public BatriderFlamebreak Flamebreak { get; }

        public BatriderFlamingLasso FlamingLasso { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BatriderStickyNapalm StickyNapalm { get; }
    }
}