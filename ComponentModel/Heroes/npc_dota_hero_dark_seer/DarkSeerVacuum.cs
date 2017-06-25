// <copyright file="DarkSeerVacuum.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dark_seer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dark_seer_vacuum)]
    public class DarkSeerVacuum : IAbilityComponent
    {
        [ImportingConstructor]
        public DarkSeerVacuum([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dark_seer_vacuum))
        {
        }

        public DarkSeerVacuum(IServiceContext context, IAbilityComponent ability)
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