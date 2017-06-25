// <copyright file="SvenGodsStrength.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_sven
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.sven_gods_strength)]
    public class SvenGodsStrength : IAbilityComponent
    {
        [ImportingConstructor]
        public SvenGodsStrength([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.sven_gods_strength))
        {
        }

        public SvenGodsStrength(IServiceContext context, IAbilityComponent ability)
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