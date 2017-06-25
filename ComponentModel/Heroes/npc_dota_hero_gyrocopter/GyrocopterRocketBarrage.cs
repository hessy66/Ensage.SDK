// <copyright file="GyrocopterRocketBarrage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_gyrocopter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.gyrocopter_rocket_barrage)]
    public class GyrocopterRocketBarrage : IAbilityComponent
    {
        [ImportingConstructor]
        public GyrocopterRocketBarrage([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.gyrocopter_rocket_barrage))
        {
        }

        public GyrocopterRocketBarrage(IServiceContext context, IAbilityComponent ability)
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