// <copyright file="DragonKnightFrostBreath.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_dragon_knight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.dragon_knight_frost_breath)]
    public class DragonKnightFrostBreath : IAbilityComponent
    {
        [ImportingConstructor]
        public DragonKnightFrostBreath([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.dragon_knight_frost_breath))
        {
        }

        public DragonKnightFrostBreath(IServiceContext context, IAbilityComponent ability)
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