// <copyright file="OmniknightRepel.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_omniknight
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.omniknight_repel)]
    public class OmniknightRepel : IAbilityComponent
    {
        [ImportingConstructor]
        public OmniknightRepel([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.omniknight_repel))
        {
        }

        public OmniknightRepel(IServiceContext context, IAbilityComponent ability)
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