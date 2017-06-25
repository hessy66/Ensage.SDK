// <copyright file="PuckDreamCoil.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_puck
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.puck_dream_coil)]
    public class PuckDreamCoil : IAbilityComponent
    {
        [ImportingConstructor]
        public PuckDreamCoil([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.puck_dream_coil))
        {
        }

        public PuckDreamCoil(IServiceContext context, IAbilityComponent ability)
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