// <copyright file="Beastmaster.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_beastmaster)]
    public class Beastmaster : IHeroComponent
    {
        [ImportingConstructor]
        public Beastmaster([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Beastmaster(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.WildAxes = new BeastmasterWildAxes(context);
            this.CallOfTheWild = new BeastmasterCallOfTheWild(context);
            this.HawkInvisibility = new BeastmasterHawkInvisibility(context);
            this.BoarPoison = new BeastmasterBoarPoison(context);
            this.InnerBeast = new BeastmasterInnerBeast(context);
            this.PrimalRoar = new BeastmasterPrimalRoar(context);
            this.GreaterBoarPoison = new BeastmasterGreaterBoarPoison(context);
            this.CallOfTheWildBoar = new BeastmasterCallOfTheWildBoar(context);
        }

        public BeastmasterBoarPoison BoarPoison { get; }

        public BeastmasterCallOfTheWild CallOfTheWild { get; }

        public BeastmasterCallOfTheWildBoar CallOfTheWildBoar { get; }

        public BeastmasterGreaterBoarPoison GreaterBoarPoison { get; }

        public BeastmasterHawkInvisibility HawkInvisibility { get; }

        public IHeroComponent Hero { get; }

        public BeastmasterInnerBeast InnerBeast { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public BeastmasterPrimalRoar PrimalRoar { get; }

        public BeastmasterWildAxes WildAxes { get; }
    }
}