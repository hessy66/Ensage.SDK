// <copyright file="TinyCraggyExterior.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tiny
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tiny_craggy_exterior)]
    public class TinyCraggyExterior : IAbilityComponent
    {
        [ImportingConstructor]
        public TinyCraggyExterior([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tiny_craggy_exterior))
        {
        }

        public TinyCraggyExterior(IServiceContext context, IAbilityComponent ability)
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