// <copyright file="Warlock.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_warlock
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_warlock)]
    public class Warlock : IHeroComponent
    {
        [ImportingConstructor]
        public Warlock([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Warlock(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FatalBonds = new WarlockFatalBonds(context);
            this.ShadowWord = new WarlockShadowWord(context);
            this.Upheaval = new WarlockUpheaval(context);
            this.RainOfChaos = new WarlockRainOfChaos(context);
            this.GolemFlamingFists = new WarlockGolemFlamingFists(context);
            this.GolemPermanentImmolation = new WarlockGolemPermanentImmolation(context);
        }

        public WarlockFatalBonds FatalBonds { get; }

        public WarlockGolemFlamingFists GolemFlamingFists { get; }

        public WarlockGolemPermanentImmolation GolemPermanentImmolation { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public WarlockRainOfChaos RainOfChaos { get; }

        public WarlockShadowWord ShadowWord { get; }

        public WarlockUpheaval Upheaval { get; }
    }
}