// <copyright file="ClinkzDeathPact.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_clinkz
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.clinkz_death_pact)]
    public class ClinkzDeathPact : IAbilityComponent
    {
        [ImportingConstructor]
        public ClinkzDeathPact([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.clinkz_death_pact))
        {
        }

        public ClinkzDeathPact(IServiceContext context, IAbilityComponent ability)
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