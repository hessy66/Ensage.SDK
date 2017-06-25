// <copyright file="UrsaFurySwipes.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ursa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ursa_fury_swipes)]
    public class UrsaFurySwipes : IAbilityComponent
    {
        [ImportingConstructor]
        public UrsaFurySwipes([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ursa_fury_swipes))
        {
        }

        public UrsaFurySwipes(IServiceContext context, IAbilityComponent ability)
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