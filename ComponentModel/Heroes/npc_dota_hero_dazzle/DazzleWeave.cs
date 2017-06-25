// <copyright file="DazzleWeave.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dazzle
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dazzle_weave)]
    public class DazzleWeave : IAbilityComponent
    {
        [ImportingConstructor]
        public DazzleWeave([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dazzle_weave))
        {
        }

        public DazzleWeave(IServiceContext context, IAbilityComponent ability)
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