// <copyright file="ViperCorrosiveSkin.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_viper
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.viper_corrosive_skin)]
    public class ViperCorrosiveSkin : IAbilityComponent
    {
        [ImportingConstructor]
        public ViperCorrosiveSkin([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.viper_corrosive_skin))
        {
        }

        public ViperCorrosiveSkin(IServiceContext context, IAbilityComponent ability)
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