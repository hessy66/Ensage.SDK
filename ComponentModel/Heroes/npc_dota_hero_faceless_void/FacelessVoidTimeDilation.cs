// <copyright file="FacelessVoidTimeDilation.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_faceless_void
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.faceless_void_time_dilation)]
    public class FacelessVoidTimeDilation : IAbilityComponent
    {
        [ImportingConstructor]
        public FacelessVoidTimeDilation([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.faceless_void_time_dilation))
        {
        }

        public FacelessVoidTimeDilation(IServiceContext context, IAbilityComponent ability)
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