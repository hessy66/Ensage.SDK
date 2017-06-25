// <copyright file="PhoenixIcarusDiveStop.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_phoenix
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.phoenix_icarus_dive_stop)]
    public class PhoenixIcarusDiveStop : IAbilityComponent
    {
        [ImportingConstructor]
        public PhoenixIcarusDiveStop([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.phoenix_icarus_dive_stop))
        {
        }

        public PhoenixIcarusDiveStop(IServiceContext context, IAbilityComponent ability)
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