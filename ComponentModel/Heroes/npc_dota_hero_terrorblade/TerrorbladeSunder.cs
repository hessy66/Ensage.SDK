// <copyright file="TerrorbladeSunder.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_terrorblade
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.terrorblade_sunder)]
    public class TerrorbladeSunder : IAbilityComponent
    {
        [ImportingConstructor]
        public TerrorbladeSunder([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.terrorblade_sunder))
        {
        }

        public TerrorbladeSunder(IServiceContext context, IAbilityComponent ability)
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