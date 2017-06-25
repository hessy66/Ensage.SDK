// <copyright file="DoomBringerInfernalBlade.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_doom_bringer
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.doom_bringer_infernal_blade)]
    public class DoomBringerInfernalBlade : IAbilityComponent
    {
        [ImportingConstructor]
        public DoomBringerInfernalBlade([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.doom_bringer_infernal_blade))
        {
        }

        public DoomBringerInfernalBlade(IServiceContext context, IAbilityComponent ability)
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