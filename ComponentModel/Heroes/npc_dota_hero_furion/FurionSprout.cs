// <copyright file="FurionSprout.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_furion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.furion_sprout)]
    public class FurionSprout : IAbilityComponent
    {
        [ImportingConstructor]
        public FurionSprout([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.furion_sprout))
        {
        }

        public FurionSprout(IServiceContext context, IAbilityComponent ability)
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