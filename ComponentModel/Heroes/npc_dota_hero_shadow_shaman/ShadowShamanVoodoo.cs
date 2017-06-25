// <copyright file="ShadowShamanVoodoo.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_shadow_shaman
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.shadow_shaman_voodoo)]
    public class ShadowShamanVoodoo : IAbilityComponent
    {
        [ImportingConstructor]
        public ShadowShamanVoodoo([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.shadow_shaman_voodoo))
        {
        }

        public ShadowShamanVoodoo(IServiceContext context, IAbilityComponent ability)
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