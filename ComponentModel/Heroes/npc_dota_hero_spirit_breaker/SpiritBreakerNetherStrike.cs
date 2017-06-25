// <copyright file="SpiritBreakerNetherStrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spirit_breaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.spirit_breaker_nether_strike)]
    public class SpiritBreakerNetherStrike : IAbilityComponent
    {
        [ImportingConstructor]
        public SpiritBreakerNetherStrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.spirit_breaker_nether_strike))
        {
        }

        public SpiritBreakerNetherStrike(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }
    }
}