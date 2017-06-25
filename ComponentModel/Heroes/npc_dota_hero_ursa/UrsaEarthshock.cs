// <copyright file="UrsaEarthshock.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ursa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ursa_earthshock)]
    public class UrsaEarthshock : IAbilityComponent
    {
        [ImportingConstructor]
        public UrsaEarthshock([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ursa_earthshock))
        {
        }

        public UrsaEarthshock(IServiceContext context, IAbilityComponent ability)
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