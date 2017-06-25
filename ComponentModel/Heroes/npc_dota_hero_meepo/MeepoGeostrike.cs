// <copyright file="MeepoGeostrike.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_meepo
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.meepo_geostrike)]
    public class MeepoGeostrike : IAbilityComponent
    {
        [ImportingConstructor]
        public MeepoGeostrike([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.meepo_geostrike))
        {
        }

        public MeepoGeostrike(IServiceContext context, IAbilityComponent ability)
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