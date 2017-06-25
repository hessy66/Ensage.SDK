// <copyright file="AntimageManaVoid.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_antimage
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.antimage_mana_void)]
    public class AntimageManaVoid : IAbilityComponent
    {
        [ImportingConstructor]
        public AntimageManaVoid([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.antimage_mana_void))
        {
        }

        public AntimageManaVoid(IServiceContext context, IAbilityComponent ability)
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