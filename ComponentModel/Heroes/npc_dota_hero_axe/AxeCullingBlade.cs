// <copyright file="AxeCullingBlade.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_axe
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.axe_culling_blade)]
    public class AxeCullingBlade : IAbilityComponent
    {
        [ImportingConstructor]
        public AxeCullingBlade([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.axe_culling_blade))
        {
        }

        public AxeCullingBlade(IServiceContext context, IAbilityComponent ability)
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