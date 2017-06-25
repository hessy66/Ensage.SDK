// <copyright file="Bane.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bane
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_bane)]
    public class Bane : IHeroComponent
    {
        [ImportingConstructor]
        public Bane([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Bane(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BrainSap = new BaneBrainSap(context);
            this.Enfeeble = new BaneEnfeeble(context);
            this.FiendsGrip = new BaneFiendsGrip(context);
            this.Nightmare = new BaneNightmare(context);
            this.NightmareEnd = new BaneNightmareEnd(context);
        }

        public BaneBrainSap BrainSap { get; }

        public BaneEnfeeble Enfeeble { get; }

        public BaneFiendsGrip FiendsGrip { get; }

        public IHeroComponent Hero { get; }

        public BaneNightmare Nightmare { get; }

        public BaneNightmareEnd NightmareEnd { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}