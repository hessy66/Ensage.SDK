// <copyright file="TechiesLandMines.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_techies
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.techies_land_mines)]
    public class TechiesLandMines : IAbilityComponent
    {
        [ImportingConstructor]
        public TechiesLandMines([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.techies_land_mines))
        {
        }

        public TechiesLandMines(IServiceContext context, IAbilityComponent ability)
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