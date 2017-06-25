// <copyright file="SlardarAmplifyDamage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_slardar
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.slardar_amplify_damage)]
    public class SlardarAmplifyDamage : IAbilityComponent
    {
        [ImportingConstructor]
        public SlardarAmplifyDamage([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.slardar_amplify_damage))
        {
        }

        public SlardarAmplifyDamage(IServiceContext context, IAbilityComponent ability)
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