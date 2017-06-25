// <copyright file="FurionTeleportation.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_furion
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.furion_teleportation)]
    public class FurionTeleportation : IAbilityComponent
    {
        [ImportingConstructor]
        public FurionTeleportation([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.furion_teleportation))
        {
        }

        public FurionTeleportation(IServiceContext context, IAbilityComponent ability)
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