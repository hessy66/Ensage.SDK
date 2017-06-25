// <copyright file="ChenHandOfGod.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chen
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.chen_hand_of_god)]
    public class ChenHandOfGod : IAbilityComponent
    {
        [ImportingConstructor]
        public ChenHandOfGod([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.chen_hand_of_god))
        {
        }

        public ChenHandOfGod(IServiceContext context, IAbilityComponent ability)
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