// <copyright file="StormSpirit.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_storm_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_storm_spirit)]
    public class StormSpirit : IHeroComponent
    {
        [ImportingConstructor]
        public StormSpirit([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public StormSpirit(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.StaticRemnant = new StormSpiritStaticRemnant(context);
            this.ElectricVortex = new StormSpiritElectricVortex(context);
            this.Overload = new StormSpiritOverload(context);
            this.BallLightning = new StormSpiritBallLightning(context);
        }

        public StormSpiritBallLightning BallLightning { get; }

        public StormSpiritElectricVortex ElectricVortex { get; }

        public IHeroComponent Hero { get; }

        public StormSpiritOverload Overload { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public StormSpiritStaticRemnant StaticRemnant { get; }
    }
}