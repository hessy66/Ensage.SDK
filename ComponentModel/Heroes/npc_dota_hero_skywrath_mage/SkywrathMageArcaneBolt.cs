// <copyright file="SkywrathMageArcaneBolt.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_skywrath_mage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.skywrath_mage_arcane_bolt)]
    public class SkywrathMageArcaneBolt : IAbilityComponent
    {
        [ImportingConstructor]
        public SkywrathMageArcaneBolt([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.skywrath_mage_arcane_bolt))
        {
        }

        public SkywrathMageArcaneBolt(IServiceContext context, IAbilityComponent ability)
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