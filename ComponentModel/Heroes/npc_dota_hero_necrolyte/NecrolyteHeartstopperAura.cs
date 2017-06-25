// <copyright file="NecrolyteHeartstopperAura.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_necrolyte
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.necrolyte_heartstopper_aura)]
    public class NecrolyteHeartstopperAura : IAbilityComponent
    {
        [ImportingConstructor]
        public NecrolyteHeartstopperAura([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.necrolyte_heartstopper_aura))
        {
        }

        public NecrolyteHeartstopperAura(IServiceContext context, IAbilityComponent ability)
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