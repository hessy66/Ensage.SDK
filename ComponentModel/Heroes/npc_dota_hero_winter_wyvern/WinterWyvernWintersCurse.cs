// <copyright file="WinterWyvernWintersCurse.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_winter_wyvern
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.winter_wyvern_winters_curse)]
    public class WinterWyvernWintersCurse : IAbilityComponent
    {
        [ImportingConstructor]
        public WinterWyvernWintersCurse([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.winter_wyvern_winters_curse))
        {
        }

        public WinterWyvernWintersCurse(IServiceContext context, IAbilityComponent ability)
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