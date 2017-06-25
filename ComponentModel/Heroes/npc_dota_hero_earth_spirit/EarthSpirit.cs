// <copyright file="EarthSpirit.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earth_spirit
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_earth_spirit)]
    public class EarthSpirit : IHeroComponent
    {
        [ImportingConstructor]
        public EarthSpirit([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public EarthSpirit(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BoulderSmash = new EarthSpiritBoulderSmash(context);
            this.RollingBoulder = new EarthSpiritRollingBoulder(context);
            this.GeomagneticGrip = new EarthSpiritGeomagneticGrip(context);
            this.StoneCaller = new EarthSpiritStoneCaller(context);
            this.Magnetize = new EarthSpiritMagnetize(context);
            this.Petrify = new EarthSpiritPetrify(context);
        }

        public EarthSpiritBoulderSmash BoulderSmash { get; }

        public EarthSpiritGeomagneticGrip GeomagneticGrip { get; }

        public IHeroComponent Hero { get; }

        public EarthSpiritMagnetize Magnetize { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public EarthSpiritPetrify Petrify { get; }

        public EarthSpiritRollingBoulder RollingBoulder { get; }

        public EarthSpiritStoneCaller StoneCaller { get; }
    }
}