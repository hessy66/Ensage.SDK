// <copyright file="ArcWarden.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_arc_warden
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_arc_warden)]
    public class ArcWarden : IHeroComponent
    {
        [ImportingConstructor]
        public ArcWarden([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ArcWarden(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Flux = new ArcWardenFlux(context);
            this.MagneticField = new ArcWardenMagneticField(context);
            this.SparkWraith = new ArcWardenSparkWraith(context);
            this.TempestDouble = new ArcWardenTempestDouble(context);
        }

        public ArcWardenFlux Flux { get; }

        public IHeroComponent Hero { get; }

        public ArcWardenMagneticField MagneticField { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ArcWardenSparkWraith SparkWraith { get; }

        public ArcWardenTempestDouble TempestDouble { get; }
    }
}