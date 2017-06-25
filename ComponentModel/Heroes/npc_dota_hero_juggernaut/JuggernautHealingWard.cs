// <copyright file="JuggernautHealingWard.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_juggernaut
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.juggernaut_healing_ward)]
    public class JuggernautHealingWard : IAbilityComponent
    {
        [ImportingConstructor]
        public JuggernautHealingWard([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.juggernaut_healing_ward))
        {
        }

        public JuggernautHealingWard(IServiceContext context, IAbilityComponent ability)
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