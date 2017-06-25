// <copyright file="AntimageSpellShield.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_antimage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.antimage_spell_shield)]
    public class AntimageSpellShield : IAbilityComponent
    {
        [ImportingConstructor]
        public AntimageSpellShield([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.antimage_spell_shield))
        {
        }

        public AntimageSpellShield(IServiceContext context, IAbilityComponent ability)
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