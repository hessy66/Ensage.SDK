// <copyright file="DragonKnightDragonBlood.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dragon_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dragon_knight_dragon_blood)]
    public class DragonKnightDragonBlood : IAbilityComponent
    {
        [ImportingConstructor]
        public DragonKnightDragonBlood([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dragon_knight_dragon_blood))
        {
        }

        public DragonKnightDragonBlood(IServiceContext context, IAbilityComponent ability)
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