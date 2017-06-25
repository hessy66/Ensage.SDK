// <copyright file="TinkerLaser.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tinker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tinker_laser)]
    public class TinkerLaser : IAbilityComponent
    {
        [ImportingConstructor]
        public TinkerLaser([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tinker_laser))
        {
        }

        public TinkerLaser(IServiceContext context, IAbilityComponent ability)
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