// <copyright file="GyrocopterHomingMissile.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_gyrocopter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.gyrocopter_homing_missile)]
    public class GyrocopterHomingMissile : IAbilityComponent
    {
        [ImportingConstructor]
        public GyrocopterHomingMissile([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.gyrocopter_homing_missile))
        {
        }

        public GyrocopterHomingMissile(IServiceContext context, IAbilityComponent ability)
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