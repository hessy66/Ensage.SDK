// <copyright file="SpiritBreakerEmpoweringHaste.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_spirit_breaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.spirit_breaker_empowering_haste)]
    public class SpiritBreakerEmpoweringHaste : IAbilityComponent
    {
        [ImportingConstructor]
        public SpiritBreakerEmpoweringHaste([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.spirit_breaker_empowering_haste))
        {
        }

        public SpiritBreakerEmpoweringHaste(IServiceContext context, IAbilityComponent ability)
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