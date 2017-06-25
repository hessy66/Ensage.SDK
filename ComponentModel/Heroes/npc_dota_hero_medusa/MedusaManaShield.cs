// <copyright file="MedusaManaShield.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_medusa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.medusa_mana_shield)]
    public class MedusaManaShield : IAbilityComponent
    {
        [ImportingConstructor]
        public MedusaManaShield([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.medusa_mana_shield))
        {
        }

        public MedusaManaShield(IServiceContext context, IAbilityComponent ability)
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