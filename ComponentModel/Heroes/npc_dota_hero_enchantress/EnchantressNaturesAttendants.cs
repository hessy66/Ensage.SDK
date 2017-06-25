// <copyright file="EnchantressNaturesAttendants.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enchantress
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.enchantress_natures_attendants)]
    public class EnchantressNaturesAttendants : IAbilityComponent
    {
        [ImportingConstructor]
        public EnchantressNaturesAttendants([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.enchantress_natures_attendants))
        {
        }

        public EnchantressNaturesAttendants(IServiceContext context, IAbilityComponent ability)
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