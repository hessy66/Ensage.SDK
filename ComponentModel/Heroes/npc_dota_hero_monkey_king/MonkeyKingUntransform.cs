// <copyright file="MonkeyKingUntransform.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_monkey_king
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.monkey_king_untransform)]
    public class MonkeyKingUntransform : IAbilityComponent
    {
        [ImportingConstructor]
        public MonkeyKingUntransform([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.monkey_king_untransform))
        {
        }

        public MonkeyKingUntransform(IServiceContext context, IAbilityComponent ability)
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