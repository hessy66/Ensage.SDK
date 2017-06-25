// <copyright file="EnigmaMalefice.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enigma
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.enigma_malefice)]
    public class EnigmaMalefice : IAbilityComponent
    {
        [ImportingConstructor]
        public EnigmaMalefice([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.enigma_malefice))
        {
        }

        public EnigmaMalefice(IServiceContext context, IAbilityComponent ability)
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