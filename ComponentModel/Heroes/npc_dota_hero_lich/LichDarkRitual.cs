// <copyright file="LichDarkRitual.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lich
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lich_dark_ritual)]
    public class LichDarkRitual : IAbilityComponent
    {
        [ImportingConstructor]
        public LichDarkRitual([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lich_dark_ritual))
        {
        }

        public LichDarkRitual(IServiceContext context, IAbilityComponent ability)
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