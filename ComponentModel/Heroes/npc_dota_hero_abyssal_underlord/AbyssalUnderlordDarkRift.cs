// <copyright file="AbyssalUnderlordDarkRift.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_abyssal_underlord
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.abyssal_underlord_dark_rift)]
    public class AbyssalUnderlordDarkRift : IAbilityComponent
    {
        [ImportingConstructor]
        public AbyssalUnderlordDarkRift([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.abyssal_underlord_dark_rift))
        {
        }

        public AbyssalUnderlordDarkRift(IServiceContext context, IAbilityComponent ability)
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