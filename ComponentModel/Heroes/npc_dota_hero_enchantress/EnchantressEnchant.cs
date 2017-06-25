// <copyright file="EnchantressEnchant.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enchantress
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.enchantress_enchant)]
    public class EnchantressEnchant : IAbilityComponent
    {
        [ImportingConstructor]
        public EnchantressEnchant([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.enchantress_enchant))
        {
        }

        public EnchantressEnchant(IServiceContext context, IAbilityComponent ability)
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