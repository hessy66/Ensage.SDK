// <copyright file="EarthshakerEnchantTotem.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_earthshaker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.earthshaker_enchant_totem)]
    public class EarthshakerEnchantTotem : IAbilityComponent
    {
        [ImportingConstructor]
        public EarthshakerEnchantTotem([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.earthshaker_enchant_totem))
        {
        }

        public EarthshakerEnchantTotem(IServiceContext context, IAbilityComponent ability)
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