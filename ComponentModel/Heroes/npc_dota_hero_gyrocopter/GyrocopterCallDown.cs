// <copyright file="GyrocopterCallDown.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_gyrocopter
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.gyrocopter_call_down)]
    public class GyrocopterCallDown : IAbilityComponent
    {
        [ImportingConstructor]
        public GyrocopterCallDown([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.gyrocopter_call_down))
        {
        }

        public GyrocopterCallDown(IServiceContext context, IAbilityComponent ability)
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