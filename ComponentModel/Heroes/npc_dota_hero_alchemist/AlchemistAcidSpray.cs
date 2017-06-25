// <copyright file="AlchemistAcidSpray.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_alchemist
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.alchemist_acid_spray)]
    public class AlchemistAcidSpray : IAbilityComponent
    {
        [ImportingConstructor]
        public AlchemistAcidSpray([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.alchemist_acid_spray))
        {
        }

        public AlchemistAcidSpray(IServiceContext context, IAbilityComponent ability)
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