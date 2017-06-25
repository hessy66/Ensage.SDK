// <copyright file="BloodseekerThirst.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_bloodseeker
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.bloodseeker_thirst)]
    public class BloodseekerThirst : IAbilityComponent
    {
        [ImportingConstructor]
        public BloodseekerThirst([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.bloodseeker_thirst))
        {
        }

        public BloodseekerThirst(IServiceContext context, IAbilityComponent ability)
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