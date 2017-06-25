// <copyright file="FacelessVoid.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_faceless_void
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_faceless_void)]
    public class FacelessVoid : IHeroComponent
    {
        [ImportingConstructor]
        public FacelessVoid([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public FacelessVoid(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.TimeWalk = new FacelessVoidTimeWalk(context);
            this.Backtrack = new FacelessVoidBacktrack(context);
            this.TimeLock = new FacelessVoidTimeLock(context);
            this.Chronosphere = new FacelessVoidChronosphere(context);
            this.TimeDilation = new FacelessVoidTimeDilation(context);
        }

        public FacelessVoidBacktrack Backtrack { get; }

        public FacelessVoidChronosphere Chronosphere { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public FacelessVoidTimeDilation TimeDilation { get; }

        public FacelessVoidTimeLock TimeLock { get; }

        public FacelessVoidTimeWalk TimeWalk { get; }
    }
}