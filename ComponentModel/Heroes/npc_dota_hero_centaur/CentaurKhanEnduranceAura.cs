// <copyright file="CentaurKhanEnduranceAura.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.centaur_khan_endurance_aura)]
    public class CentaurKhanEnduranceAura : IAbilityComponent
    {
        [ImportingConstructor]
        public CentaurKhanEnduranceAura([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.centaur_khan_endurance_aura))
        {
        }

        public CentaurKhanEnduranceAura(IServiceContext context, IAbilityComponent ability)
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