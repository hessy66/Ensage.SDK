// <copyright file="AncientApparitionIceBlastRelease.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ancient_apparition
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ancient_apparition_ice_blast_release)]
    public class AncientApparitionIceBlastRelease : IAbilityComponent
    {
        [ImportingConstructor]
        public AncientApparitionIceBlastRelease([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ancient_apparition_ice_blast_release))
        {
        }

        public AncientApparitionIceBlastRelease(IServiceContext context, IAbilityComponent ability)
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