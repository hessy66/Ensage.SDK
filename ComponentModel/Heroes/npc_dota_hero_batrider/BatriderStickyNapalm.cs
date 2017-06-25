// <copyright file="BatriderStickyNapalm.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_batrider
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.batrider_sticky_napalm)]
    public class BatriderStickyNapalm : IAbilityComponent
    {
        [ImportingConstructor]
        public BatriderStickyNapalm([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.batrider_sticky_napalm))
        {
        }

        public BatriderStickyNapalm(IServiceContext context, IAbilityComponent ability)
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