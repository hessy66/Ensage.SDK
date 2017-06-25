// <copyright file="ChaosKnight.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chaos_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_chaos_knight)]
    public class ChaosKnight : IHeroComponent
    {
        [ImportingConstructor]
        public ChaosKnight([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public ChaosKnight(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ChaosBolt = new ChaosKnightChaosBolt(context);
            this.RealityRift = new ChaosKnightRealityRift(context);
            this.ChaosStrike = new ChaosKnightChaosStrike(context);
            this.Phantasm = new ChaosKnightPhantasm(context);
        }

        public ChaosKnightChaosBolt ChaosBolt { get; }

        public ChaosKnightChaosStrike ChaosStrike { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ChaosKnightPhantasm Phantasm { get; }

        public ChaosKnightRealityRift RealityRift { get; }
    }
}