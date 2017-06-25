// <copyright file="MedusaStoneGaze.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_medusa
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.medusa_stone_gaze)]
    public class MedusaStoneGaze : IAbilityComponent
    {
        [ImportingConstructor]
        public MedusaStoneGaze([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.medusa_stone_gaze))
        {
        }

        public MedusaStoneGaze(IServiceContext context, IAbilityComponent ability)
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