// <copyright file="JuggernautBladeFury.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_juggernaut
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.juggernaut_blade_fury)]
    public class JuggernautBladeFury : IAbilityComponent
    {
        [ImportingConstructor]
        public JuggernautBladeFury([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.juggernaut_blade_fury))
        {
        }

        public JuggernautBladeFury(IServiceContext context, IAbilityComponent ability)
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