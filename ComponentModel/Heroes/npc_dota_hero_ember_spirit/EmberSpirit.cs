// <copyright file="EmberSpirit.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ember_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_ember_spirit)]
    public class EmberSpirit : IHeroComponent
    {
        [ImportingConstructor]
        public EmberSpirit([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public EmberSpirit(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SearingChains = new EmberSpiritSearingChains(context);
            this.SleightOfFist = new EmberSpiritSleightOfFist(context);
            this.FlameGuard = new EmberSpiritFlameGuard(context);
            this.FireRemnant = new EmberSpiritFireRemnant(context);
            this.ActivateFireRemnant = new EmberSpiritActivateFireRemnant(context);
        }

        public EmberSpiritActivateFireRemnant ActivateFireRemnant { get; }

        public EmberSpiritFireRemnant FireRemnant { get; }

        public EmberSpiritFlameGuard FlameGuard { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public EmberSpiritSearingChains SearingChains { get; }

        public EmberSpiritSleightOfFist SleightOfFist { get; }
    }
}