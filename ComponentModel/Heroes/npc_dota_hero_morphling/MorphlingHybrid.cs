// <copyright file="MorphlingHybrid.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_morphling
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.morphling_hybrid)]
    public class MorphlingHybrid : IAbilityComponent
    {
        [ImportingConstructor]
        public MorphlingHybrid([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.morphling_hybrid))
        {
        }

        public MorphlingHybrid(IServiceContext context, IAbilityComponent ability)
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