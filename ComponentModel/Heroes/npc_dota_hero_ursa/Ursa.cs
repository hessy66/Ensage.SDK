// <copyright file="Ursa.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ursa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_ursa)]
    public class Ursa : IHeroComponent
    {
        [ImportingConstructor]
        public Ursa([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Ursa(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.Earthshock = new UrsaEarthshock(context);
            this.Overpower = new UrsaOverpower(context);
            this.FurySwipes = new UrsaFurySwipes(context);
            this.Enrage = new UrsaEnrage(context);
        }

        public UrsaEarthshock Earthshock { get; }

        public UrsaEnrage Enrage { get; }

        public UrsaFurySwipes FurySwipes { get; }

        public IHeroComponent Hero { get; }

        public UrsaOverpower Overpower { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}