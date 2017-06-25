// <copyright file="SpiritBreaker.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spirit_breaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.ComponentModel.Metadata;
    using Ensage.SDK.Service;

    [ExportHeroComponent(HeroId.npc_dota_hero_spirit_breaker)]
    public class SpiritBreaker : IHeroComponent
    {
        [ImportingConstructor]
        public SpiritBreaker([Import] IServiceContext context)
            : this(context, new HeroComponent(context))
        {
        }

        public SpiritBreaker(IServiceContext context, IHeroComponent hero)
        {
            this.Hero = hero;
            this.ChargeOfDarkness = new SpiritBreakerChargeOfDarkness(context);
            this.EmpoweringHaste = new SpiritBreakerEmpoweringHaste(context);
            this.GreaterBash = new SpiritBreakerGreaterBash(context);
            this.NetherStrike = new SpiritBreakerNetherStrike(context);
        }

        public SpiritBreakerChargeOfDarkness ChargeOfDarkness { get; }

        public SpiritBreakerEmpoweringHaste EmpoweringHaste { get; }

        public SpiritBreakerGreaterBash GreaterBash { get; }

        public IHeroComponent Hero { get; }

        public SpiritBreakerNetherStrike NetherStrike { get; }

        public Hero Owner
        {
            get
            {
                return this.Hero.Owner;
            }
        }
    }
}