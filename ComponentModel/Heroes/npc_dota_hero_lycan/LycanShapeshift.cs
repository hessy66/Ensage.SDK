// <copyright file="LycanShapeshift.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_lycan
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.lycan_shapeshift)]
    public class LycanShapeshift : IAbilityComponent
    {
        [ImportingConstructor]
        public LycanShapeshift([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.lycan_shapeshift))
        {
        }

        public LycanShapeshift(IServiceContext context, IAbilityComponent ability)
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