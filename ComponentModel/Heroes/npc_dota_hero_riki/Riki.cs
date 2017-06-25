// <copyright file="Riki.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_riki
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_riki)]
    public class Riki : IHeroComponent
    {
        [ImportingConstructor]
        public Riki([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Riki(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.SmokeScreen = new RikiSmokeScreen(context);
            this.BlinkStrike = new RikiBlinkStrike(context);
            this.PermanentInvisibility = new RikiPermanentInvisibility(context);
            this.TricksOfTheTrade = new RikiTricksOfTheTrade(context);
        }

        public RikiBlinkStrike BlinkStrike { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public RikiPermanentInvisibility PermanentInvisibility { get; }

        public RikiSmokeScreen SmokeScreen { get; }

        public RikiTricksOfTheTrade TricksOfTheTrade { get; }
    }
}