// <copyright file="LegionCommanderDuel.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_legion_commander
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.legion_commander_duel)]
    public class LegionCommanderDuel : IAbilityComponent
    {
        [ImportingConstructor]
        public LegionCommanderDuel([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.legion_commander_duel))
        {
        }

        public LegionCommanderDuel(IServiceContext context, IAbilityComponent ability)
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