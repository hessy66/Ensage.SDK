// <copyright file="ShadowDemonShadowPoison.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shadow_demon
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.shadow_demon_shadow_poison)]
    public class ShadowDemonShadowPoison : IAbilityComponent
    {
        [ImportingConstructor]
        public ShadowDemonShadowPoison([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.shadow_demon_shadow_poison))
        {
        }

        public ShadowDemonShadowPoison(IServiceContext context, IAbilityComponent ability)
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