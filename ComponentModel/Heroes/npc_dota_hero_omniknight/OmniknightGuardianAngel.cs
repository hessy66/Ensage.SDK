// <copyright file="OmniknightGuardianAngel.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_omniknight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.omniknight_guardian_angel)]
    public class OmniknightGuardianAngel : IAbilityComponent
    {
        [ImportingConstructor]
        public OmniknightGuardianAngel([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.omniknight_guardian_angel))
        {
        }

        public OmniknightGuardianAngel(IServiceContext context, IAbilityComponent ability)
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