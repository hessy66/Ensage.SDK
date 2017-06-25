// <copyright file="CentaurKhanWarStomp.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_centaur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.centaur_khan_war_stomp)]
    public class CentaurKhanWarStomp : IAbilityComponent
    {
        [ImportingConstructor]
        public CentaurKhanWarStomp([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.centaur_khan_war_stomp))
        {
        }

        public CentaurKhanWarStomp(IServiceContext context, IAbilityComponent ability)
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