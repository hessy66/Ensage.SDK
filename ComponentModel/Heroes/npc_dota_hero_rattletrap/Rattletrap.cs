// <copyright file="Rattletrap.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_rattletrap
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_rattletrap)]
    public class Rattletrap : IHeroComponent
    {
        [ImportingConstructor]
        public Rattletrap([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Rattletrap(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BatteryAssault = new RattletrapBatteryAssault(context);
            this.PowerCogs = new RattletrapPowerCogs(context);
            this.RocketFlare = new RattletrapRocketFlare(context);
            this.Hookshot = new RattletrapHookshot(context);
        }

        public RattletrapBatteryAssault BatteryAssault { get; }

        public IHeroComponent Hero { get; }

        public RattletrapHookshot Hookshot { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public RattletrapPowerCogs PowerCogs { get; }

        public RattletrapRocketFlare RocketFlare { get; }
    }
}