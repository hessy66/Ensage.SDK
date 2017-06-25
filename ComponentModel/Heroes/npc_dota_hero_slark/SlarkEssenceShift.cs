// <copyright file="SlarkEssenceShift.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_slark
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.slark_essence_shift)]
    public class SlarkEssenceShift : IAbilityComponent
    {
        [ImportingConstructor]
        public SlarkEssenceShift([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.slark_essence_shift))
        {
        }

        public SlarkEssenceShift(IServiceContext context, IAbilityComponent ability)
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