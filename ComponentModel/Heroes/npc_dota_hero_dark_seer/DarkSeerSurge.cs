// <copyright file="DarkSeerSurge.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dark_seer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dark_seer_surge)]
    public class DarkSeerSurge : IAbilityComponent
    {
        [ImportingConstructor]
        public DarkSeerSurge([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dark_seer_surge))
        {
        }

        public DarkSeerSurge(IServiceContext context, IAbilityComponent ability)
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