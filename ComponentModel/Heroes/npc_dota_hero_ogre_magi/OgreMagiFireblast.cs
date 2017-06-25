// <copyright file="OgreMagiFireblast.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_ogre_magi
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.ogre_magi_fireblast)]
    public class OgreMagiFireblast : IAbilityComponent
    {
        [ImportingConstructor]
        public OgreMagiFireblast([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.ogre_magi_fireblast))
        {
        }

        public OgreMagiFireblast(IServiceContext context, IAbilityComponent ability)
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