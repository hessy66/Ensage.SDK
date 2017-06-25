// <copyright file="VisageGravekeepersCloak.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_visage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.visage_gravekeepers_cloak)]
    public class VisageGravekeepersCloak : IAbilityComponent
    {
        [ImportingConstructor]
        public VisageGravekeepersCloak([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.visage_gravekeepers_cloak))
        {
        }

        public VisageGravekeepersCloak(IServiceContext context, IAbilityComponent ability)
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