// <copyright file="LionManaDrain.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lion_mana_drain)]
    public class LionManaDrain : IAbilityComponent
    {
        [ImportingConstructor]
        public LionManaDrain([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lion_mana_drain))
        {
        }

        public LionManaDrain(IServiceContext context, IAbilityComponent ability)
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