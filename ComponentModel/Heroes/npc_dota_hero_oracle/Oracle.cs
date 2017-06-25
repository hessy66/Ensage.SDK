// <copyright file="Oracle.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_oracle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_oracle)]
    public class Oracle : IHeroComponent
    {
        [ImportingConstructor]
        public Oracle([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Oracle(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.FortunesEnd = new OracleFortunesEnd(context);
            this.FatesEdict = new OracleFatesEdict(context);
            this.PurifyingFlames = new OraclePurifyingFlames(context);
            this.FalsePromise = new OracleFalsePromise(context);
        }

        public OracleFalsePromise FalsePromise { get; }

        public OracleFatesEdict FatesEdict { get; }

        public OracleFortunesEnd FortunesEnd { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public OraclePurifyingFlames PurifyingFlames { get; }
    }
}