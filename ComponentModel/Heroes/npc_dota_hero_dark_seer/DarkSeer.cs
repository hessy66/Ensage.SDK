// <copyright file="DarkSeer.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dark_seer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_dark_seer)]
    public class DarkSeer : IHeroComponent
    {
        [ImportingConstructor]
        public DarkSeer([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public DarkSeer(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Vacuum = new DarkSeerVacuum(context);
            this.IonShell = new DarkSeerIonShell(context);
            this.Surge = new DarkSeerSurge(context);
            this.WallOfReplica = new DarkSeerWallOfReplica(context);
        }

        public IHeroComponent Hero { get; }

        public DarkSeerIonShell IonShell { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public DarkSeerSurge Surge { get; }

        public DarkSeerVacuum Vacuum { get; }

        public DarkSeerWallOfReplica WallOfReplica { get; }
    }
}