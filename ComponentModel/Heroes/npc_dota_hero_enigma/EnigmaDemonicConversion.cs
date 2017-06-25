// <copyright file="EnigmaDemonicConversion.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enigma
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.enigma_demonic_conversion)]
    public class EnigmaDemonicConversion : IAbilityComponent
    {
        [ImportingConstructor]
        public EnigmaDemonicConversion([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.enigma_demonic_conversion))
        {
        }

        public EnigmaDemonicConversion(IServiceContext context, IAbilityComponent ability)
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