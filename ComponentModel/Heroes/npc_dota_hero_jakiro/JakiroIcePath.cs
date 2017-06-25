// <copyright file="JakiroIcePath.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_jakiro
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.jakiro_ice_path)]
    public class JakiroIcePath : IAbilityComponent
    {
        [ImportingConstructor]
        public JakiroIcePath([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.jakiro_ice_path))
        {
        }

        public JakiroIcePath(IServiceContext context, IAbilityComponent ability)
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