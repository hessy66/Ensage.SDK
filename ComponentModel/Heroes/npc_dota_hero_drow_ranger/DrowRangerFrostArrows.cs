// <copyright file="DrowRangerFrostArrows.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_drow_ranger
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.drow_ranger_frost_arrows)]
    public class DrowRangerFrostArrows : IAbilityComponent
    {
        [ImportingConstructor]
        public DrowRangerFrostArrows([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.drow_ranger_frost_arrows))
        {
        }

        public DrowRangerFrostArrows(IServiceContext context, IAbilityComponent ability)
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