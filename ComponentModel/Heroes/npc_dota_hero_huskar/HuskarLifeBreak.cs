// <copyright file="HuskarLifeBreak.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_huskar
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.huskar_life_break)]
    public class HuskarLifeBreak : IAbilityComponent
    {
        [ImportingConstructor]
        public HuskarLifeBreak([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.huskar_life_break))
        {
        }

        public HuskarLifeBreak(IServiceContext context, IAbilityComponent ability)
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