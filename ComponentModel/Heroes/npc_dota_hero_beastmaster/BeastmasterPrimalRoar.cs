// <copyright file="BeastmasterPrimalRoar.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_beastmaster
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.beastmaster_primal_roar)]
    public class BeastmasterPrimalRoar : IAbilityComponent
    {
        [ImportingConstructor]
        public BeastmasterPrimalRoar([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.beastmaster_primal_roar))
        {
        }

        public BeastmasterPrimalRoar(IServiceContext context, IAbilityComponent ability)
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