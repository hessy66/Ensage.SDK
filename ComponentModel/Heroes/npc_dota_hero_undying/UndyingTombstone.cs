// <copyright file="UndyingTombstone.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_undying
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.undying_tombstone)]
    public class UndyingTombstone : IAbilityComponent
    {
        [ImportingConstructor]
        public UndyingTombstone([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.undying_tombstone))
        {
        }

        public UndyingTombstone(IServiceContext context, IAbilityComponent ability)
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