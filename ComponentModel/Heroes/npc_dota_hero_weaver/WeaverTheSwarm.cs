// <copyright file="WeaverTheSwarm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_weaver
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.weaver_the_swarm)]
    public class WeaverTheSwarm : IAbilityComponent
    {
        [ImportingConstructor]
        public WeaverTheSwarm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.weaver_the_swarm))
        {
        }

        public WeaverTheSwarm(IServiceContext context, IAbilityComponent ability)
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