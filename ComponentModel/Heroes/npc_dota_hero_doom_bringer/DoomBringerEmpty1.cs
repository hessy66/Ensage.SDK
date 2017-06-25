// <copyright file="DoomBringerEmpty1.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_doom_bringer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.doom_bringer_empty1)]
    public class DoomBringerEmpty1 : IAbilityComponent
    {
        [ImportingConstructor]
        public DoomBringerEmpty1([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.doom_bringer_empty1))
        {
        }

        public DoomBringerEmpty1(IServiceContext context, IAbilityComponent ability)
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