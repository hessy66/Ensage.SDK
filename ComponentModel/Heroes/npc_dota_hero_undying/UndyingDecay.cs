// <copyright file="UndyingDecay.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_undying
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.undying_decay)]
    public class UndyingDecay : IAbilityComponent
    {
        [ImportingConstructor]
        public UndyingDecay([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.undying_decay))
        {
        }

        public UndyingDecay(IServiceContext context, IAbilityComponent ability)
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