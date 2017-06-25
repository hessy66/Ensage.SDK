// <copyright file="Brewmaster.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_brewmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_brewmaster)]
    public class Brewmaster : IHeroComponent
    {
        [ImportingConstructor]
        public Brewmaster([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Brewmaster(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ThunderClap = new BrewmasterThunderClap(context);
            this.DrunkenHaze = new BrewmasterDrunkenHaze(context);
            this.DrunkenBrawler = new BrewmasterDrunkenBrawler(context);
            this.PrimalSplit = new BrewmasterPrimalSplit(context);
            this.EarthHurlBoulder = new BrewmasterEarthHurlBoulder(context);
            this.EarthSpellImmunity = new BrewmasterEarthSpellImmunity(context);
            this.EarthPulverize = new BrewmasterEarthPulverize(context);
            this.StormDispelMagic = new BrewmasterStormDispelMagic(context);
            this.StormCyclone = new BrewmasterStormCyclone(context);
            this.StormWindWalk = new BrewmasterStormWindWalk(context);
            this.FirePermanentImmolation = new BrewmasterFirePermanentImmolation(context);
        }

        public BrewmasterDrunkenBrawler DrunkenBrawler { get; }

        public BrewmasterDrunkenHaze DrunkenHaze { get; }

        public BrewmasterEarthHurlBoulder EarthHurlBoulder { get; }

        public BrewmasterEarthPulverize EarthPulverize { get; }

        public BrewmasterEarthSpellImmunity EarthSpellImmunity { get; }

        public BrewmasterFirePermanentImmolation FirePermanentImmolation { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BrewmasterPrimalSplit PrimalSplit { get; }

        public BrewmasterStormCyclone StormCyclone { get; }

        public BrewmasterStormDispelMagic StormDispelMagic { get; }

        public BrewmasterStormWindWalk StormWindWalk { get; }

        public BrewmasterThunderClap ThunderClap { get; }
    }
}