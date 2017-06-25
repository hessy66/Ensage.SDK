// <copyright file="LichFrostNova.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lich
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lich_frost_nova)]
    public class LichFrostNova : IAbilityComponent
    {
        [ImportingConstructor]
        public LichFrostNova([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lich_frost_nova))
        {
        }

        public LichFrostNova(IServiceContext context, IAbilityComponent ability)
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