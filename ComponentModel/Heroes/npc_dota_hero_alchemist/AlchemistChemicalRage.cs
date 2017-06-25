// <copyright file="AlchemistChemicalRage.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_alchemist
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.alchemist_chemical_rage)]
    public class AlchemistChemicalRage : IAbilityComponent
    {
        [ImportingConstructor]
        public AlchemistChemicalRage([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.alchemist_chemical_rage))
        {
        }

        public AlchemistChemicalRage(IServiceContext context, IAbilityComponent ability)
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