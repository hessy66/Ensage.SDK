// <copyright file="JuggernautOmniSlash.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_juggernaut
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.juggernaut_omni_slash)]
    public class JuggernautOmniSlash : IAbilityComponent
    {
        [ImportingConstructor]
        public JuggernautOmniSlash([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.juggernaut_omni_slash))
        {
        }

        public JuggernautOmniSlash(IServiceContext context, IAbilityComponent ability)
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