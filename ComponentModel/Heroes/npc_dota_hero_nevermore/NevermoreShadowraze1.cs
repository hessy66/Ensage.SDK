// <copyright file="NevermoreShadowraze1.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nevermore
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nevermore_shadowraze1)]
    public class NevermoreShadowraze1 : IAbilityComponent
    {
        [ImportingConstructor]
        public NevermoreShadowraze1([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nevermore_shadowraze1))
        {
        }

        public NevermoreShadowraze1(IServiceContext context, IAbilityComponent ability)
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