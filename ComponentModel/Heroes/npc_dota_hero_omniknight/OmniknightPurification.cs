// <copyright file="OmniknightPurification.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_omniknight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.omniknight_purification)]
    public class OmniknightPurification : IAbilityComponent
    {
        [ImportingConstructor]
        public OmniknightPurification([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.omniknight_purification))
        {
        }

        public OmniknightPurification(IServiceContext context, IAbilityComponent ability)
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