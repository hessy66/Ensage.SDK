// <copyright file="ShadowDemonDemonicPurge.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shadow_demon
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.shadow_demon_demonic_purge)]
    public class ShadowDemonDemonicPurge : IAbilityComponent
    {
        [ImportingConstructor]
        public ShadowDemonDemonicPurge([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.shadow_demon_demonic_purge))
        {
        }

        public ShadowDemonDemonicPurge(IServiceContext context, IAbilityComponent ability)
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