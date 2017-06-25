// <copyright file="BaneFiendsGrip.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bane
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.bane_fiends_grip)]
    public class BaneFiendsGrip : IAbilityComponent
    {
        [ImportingConstructor]
        public BaneFiendsGrip([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.bane_fiends_grip))
        {
        }

        public BaneFiendsGrip(IServiceContext context, IAbilityComponent ability)
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