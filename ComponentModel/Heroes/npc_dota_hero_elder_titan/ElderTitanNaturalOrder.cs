// <copyright file="ElderTitanNaturalOrder.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_elder_titan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.elder_titan_natural_order)]
    public class ElderTitanNaturalOrder : IAbilityComponent
    {
        [ImportingConstructor]
        public ElderTitanNaturalOrder([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.elder_titan_natural_order))
        {
        }

        public ElderTitanNaturalOrder(IServiceContext context, IAbilityComponent ability)
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