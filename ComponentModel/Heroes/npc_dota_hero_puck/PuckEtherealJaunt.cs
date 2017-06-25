// <copyright file="PuckEtherealJaunt.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_puck
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.puck_ethereal_jaunt)]
    public class PuckEtherealJaunt : IAbilityComponent
    {
        [ImportingConstructor]
        public PuckEtherealJaunt([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.puck_ethereal_jaunt))
        {
        }

        public PuckEtherealJaunt(IServiceContext context, IAbilityComponent ability)
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