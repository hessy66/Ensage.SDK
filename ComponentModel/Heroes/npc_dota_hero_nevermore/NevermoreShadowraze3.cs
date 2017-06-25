// <copyright file="NevermoreShadowraze3.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_nevermore
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.nevermore_shadowraze3)]
    public class NevermoreShadowraze3 : IAbilityComponent
    {
        [ImportingConstructor]
        public NevermoreShadowraze3([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.nevermore_shadowraze3))
        {
        }

        public NevermoreShadowraze3(IServiceContext context, IAbilityComponent ability)
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