// <copyright file="FacelessVoidChronosphere.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_faceless_void
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.faceless_void_chronosphere)]
    public class FacelessVoidChronosphere : IAbilityComponent
    {
        [ImportingConstructor]
        public FacelessVoidChronosphere([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.faceless_void_chronosphere))
        {
        }

        public FacelessVoidChronosphere(IServiceContext context, IAbilityComponent ability)
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