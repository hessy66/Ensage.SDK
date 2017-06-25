// <copyright file="WispRelocate.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_wisp
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.wisp_relocate)]
    public class WispRelocate : IAbilityComponent
    {
        [ImportingConstructor]
        public WispRelocate([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.wisp_relocate))
        {
        }

        public WispRelocate(IServiceContext context, IAbilityComponent ability)
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