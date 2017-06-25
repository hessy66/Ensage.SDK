// <copyright file="WeaverTimeLapse.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_weaver
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.weaver_time_lapse)]
    public class WeaverTimeLapse : IAbilityComponent
    {
        [ImportingConstructor]
        public WeaverTimeLapse([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.weaver_time_lapse))
        {
        }

        public WeaverTimeLapse(IServiceContext context, IAbilityComponent ability)
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