// <copyright file="DoomBringerDevour.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_doom_bringer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.doom_bringer_devour)]
    public class DoomBringerDevour : IAbilityComponent
    {
        [ImportingConstructor]
        public DoomBringerDevour([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.doom_bringer_devour))
        {
        }

        public DoomBringerDevour(IServiceContext context, IAbilityComponent ability)
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