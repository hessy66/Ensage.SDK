// <copyright file="HuskarBerserkersBlood.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_huskar
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.huskar_berserkers_blood)]
    public class HuskarBerserkersBlood : IAbilityComponent
    {
        [ImportingConstructor]
        public HuskarBerserkersBlood([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.huskar_berserkers_blood))
        {
        }

        public HuskarBerserkersBlood(IServiceContext context, IAbilityComponent ability)
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