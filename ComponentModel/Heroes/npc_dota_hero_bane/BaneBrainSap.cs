// <copyright file="BaneBrainSap.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bane
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.bane_brain_sap)]
    public class BaneBrainSap : IAbilityComponent
    {
        [ImportingConstructor]
        public BaneBrainSap([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.bane_brain_sap))
        {
        }

        public BaneBrainSap(IServiceContext context, IAbilityComponent ability)
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