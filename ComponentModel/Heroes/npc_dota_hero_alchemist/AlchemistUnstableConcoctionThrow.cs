// <copyright file="AlchemistUnstableConcoctionThrow.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_alchemist
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.alchemist_unstable_concoction_throw)]
    public class AlchemistUnstableConcoctionThrow : IAbilityComponent
    {
        [ImportingConstructor]
        public AlchemistUnstableConcoctionThrow([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.alchemist_unstable_concoction_throw))
        {
        }

        public AlchemistUnstableConcoctionThrow(IServiceContext context, IAbilityComponent ability)
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