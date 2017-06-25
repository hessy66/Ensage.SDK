// <copyright file="TinyGrow.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_tiny
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.tiny_grow)]
    public class TinyGrow : IAbilityComponent
    {
        [ImportingConstructor]
        public TinyGrow([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.tiny_grow))
        {
        }

        public TinyGrow(IServiceContext context, IAbilityComponent ability)
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