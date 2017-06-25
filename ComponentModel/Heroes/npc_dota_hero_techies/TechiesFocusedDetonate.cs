// <copyright file="TechiesFocusedDetonate.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_techies
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.techies_focused_detonate)]
    public class TechiesFocusedDetonate : IAbilityComponent
    {
        [ImportingConstructor]
        public TechiesFocusedDetonate([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.techies_focused_detonate))
        {
        }

        public TechiesFocusedDetonate(IServiceContext context, IAbilityComponent ability)
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