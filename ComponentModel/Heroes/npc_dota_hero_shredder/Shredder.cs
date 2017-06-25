// <copyright file="Shredder.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shredder
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_shredder)]
    public class Shredder : IHeroComponent
    {
        [ImportingConstructor]
        public Shredder([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public Shredder(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.WhirlingDeath = new ShredderWhirlingDeath(context);
            this.TimberChain = new ShredderTimberChain(context);
            this.ReactiveArmor = new ShredderReactiveArmor(context);
            this.Chakram = new ShredderChakram(context);
            this.ReturnChakram = new ShredderReturnChakram(context);
            this.Chakram2 = new ShredderChakram2(context);
            this.ReturnChakram2 = new ShredderReturnChakram2(context);
        }

        public ShredderChakram Chakram { get; }

        public ShredderChakram2 Chakram2 { get; }

        public IHeroComponent Hero { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }

        public ShredderReactiveArmor ReactiveArmor { get; }

        public ShredderReturnChakram ReturnChakram { get; }

        public ShredderReturnChakram2 ReturnChakram2 { get; }

        public ShredderTimberChain TimberChain { get; }

        public ShredderWhirlingDeath WhirlingDeath { get; }
    }
}