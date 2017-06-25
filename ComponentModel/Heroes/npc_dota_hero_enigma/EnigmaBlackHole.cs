// <copyright file="EnigmaBlackHole.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_enigma
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.enigma_black_hole)]
    public class EnigmaBlackHole : IAbilityComponent
    {
        [ImportingConstructor]
        public EnigmaBlackHole([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.enigma_black_hole))
        {
        }

        public EnigmaBlackHole(IServiceContext context, IAbilityComponent ability)
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