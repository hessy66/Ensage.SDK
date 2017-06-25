// <copyright file="ArcWardenFlux.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_arc_warden
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.arc_warden_flux)]
    public class ArcWardenFlux : IAbilityComponent
    {
        [ImportingConstructor]
        public ArcWardenFlux([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.arc_warden_flux))
        {
        }

        public ArcWardenFlux(IServiceContext context, IAbilityComponent ability)
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