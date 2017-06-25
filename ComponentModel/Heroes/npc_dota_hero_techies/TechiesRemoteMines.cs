// <copyright file="TechiesRemoteMines.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_techies
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.techies_remote_mines)]
    public class TechiesRemoteMines : IAbilityComponent
    {
        [ImportingConstructor]
        public TechiesRemoteMines([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.techies_remote_mines))
        {
        }

        public TechiesRemoteMines(IServiceContext context, IAbilityComponent ability)
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