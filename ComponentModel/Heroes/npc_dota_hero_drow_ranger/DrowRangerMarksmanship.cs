// <copyright file="DrowRangerMarksmanship.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_drow_ranger
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.drow_ranger_marksmanship)]
    public class DrowRangerMarksmanship : IAbilityComponent
    {
        [ImportingConstructor]
        public DrowRangerMarksmanship([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.drow_ranger_marksmanship))
        {
        }

        public DrowRangerMarksmanship(IServiceContext context, IAbilityComponent ability)
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