// <copyright file="MagnataurEmpower.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_magnataur
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.magnataur_empower)]
    public class MagnataurEmpower : IAbilityComponent
    {
        [ImportingConstructor]
        public MagnataurEmpower([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.magnataur_empower))
        {
        }

        public MagnataurEmpower(IServiceContext context, IAbilityComponent ability)
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