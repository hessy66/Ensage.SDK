// <copyright file="MeepoDividedWeStand.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_meepo
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.meepo_divided_we_stand)]
    public class MeepoDividedWeStand : IAbilityComponent
    {
        [ImportingConstructor]
        public MeepoDividedWeStand([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.meepo_divided_we_stand))
        {
        }

        public MeepoDividedWeStand(IServiceContext context, IAbilityComponent ability)
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