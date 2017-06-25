// <copyright file="SlarkShadowDance.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_slark
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.slark_shadow_dance)]
    public class SlarkShadowDance : IAbilityComponent
    {
        [ImportingConstructor]
        public SlarkShadowDance([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.slark_shadow_dance))
        {
        }

        public SlarkShadowDance(IServiceContext context, IAbilityComponent ability)
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