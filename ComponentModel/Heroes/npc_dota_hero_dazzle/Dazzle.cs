// <copyright file="Dazzle.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dazzle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_dazzle)]
    public class Dazzle : IHeroComponent
    {
        [ImportingConstructor]
        public Dazzle([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Dazzle(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.PoisonTouch = new DazzlePoisonTouch(context);
            this.ShallowGrave = new DazzleShallowGrave(context);
            this.ShadowWave = new DazzleShadowWave(context);
            this.Weave = new DazzleWeave(context);
        }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DazzlePoisonTouch PoisonTouch { get; }

        public DazzleShadowWave ShadowWave { get; }

        public DazzleShallowGrave ShallowGrave { get; }

        public DazzleWeave Weave { get; }
    }
}