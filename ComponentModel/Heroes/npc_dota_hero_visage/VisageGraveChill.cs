// <copyright file="VisageGraveChill.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_visage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.visage_grave_chill)]
    public class VisageGraveChill : IAbilityComponent
    {
        [ImportingConstructor]
        public VisageGraveChill([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.visage_grave_chill))
        {
        }

        public VisageGraveChill(IServiceContext context, IAbilityComponent ability)
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