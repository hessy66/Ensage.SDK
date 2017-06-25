// <copyright file="ZuusArcLightning.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_zuus
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.zuus_arc_lightning)]
    public class ZuusArcLightning : IAbilityComponent
    {
        [ImportingConstructor]
        public ZuusArcLightning([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.zuus_arc_lightning))
        {
        }

        public ZuusArcLightning(IServiceContext context, IAbilityComponent ability)
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