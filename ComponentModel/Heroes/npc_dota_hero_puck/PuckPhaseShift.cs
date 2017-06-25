// <copyright file="PuckPhaseShift.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_puck
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.puck_phase_shift)]
    public class PuckPhaseShift : IAbilityComponent
    {
        [ImportingConstructor]
        public PuckPhaseShift([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.puck_phase_shift))
        {
        }

        public PuckPhaseShift(IServiceContext context, IAbilityComponent ability)
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