// <copyright file="Clinkz.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_clinkz
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_clinkz)]
    public class Clinkz : IHeroComponent
    {
        [ImportingConstructor]
        public Clinkz([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Clinkz(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Strafe = new ClinkzStrafe(context);
            this.SearingArrows = new ClinkzSearingArrows(context);
            this.WindWalk = new ClinkzWindWalk(context);
            this.DeathPact = new ClinkzDeathPact(context);
        }

        public ClinkzDeathPact DeathPact { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ClinkzSearingArrows SearingArrows { get; }

        public ClinkzStrafe Strafe { get; }

        public ClinkzWindWalk WindWalk { get; }
    }
}