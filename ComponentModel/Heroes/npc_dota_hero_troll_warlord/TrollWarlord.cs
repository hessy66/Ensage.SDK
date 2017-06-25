// <copyright file="TrollWarlord.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_troll_warlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_troll_warlord)]
    public class TrollWarlord : IHeroComponent
    {
        [ImportingConstructor]
        public TrollWarlord([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public TrollWarlord(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.BerserkersRage = new TrollWarlordBerserkersRage(context);
            this.WhirlingAxesRanged = new TrollWarlordWhirlingAxesRanged(context);
            this.WhirlingAxesMelee = new TrollWarlordWhirlingAxesMelee(context);
            this.Fervor = new TrollWarlordFervor(context);
            this.BattleTrance = new TrollWarlordBattleTrance(context);
        }

        public TrollWarlordBattleTrance BattleTrance { get; }

        public TrollWarlordBerserkersRage BerserkersRage { get; }

        public TrollWarlordFervor Fervor { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public TrollWarlordWhirlingAxesMelee WhirlingAxesMelee { get; }

        public TrollWarlordWhirlingAxesRanged WhirlingAxesRanged { get; }
    }
}