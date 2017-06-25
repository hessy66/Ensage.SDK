// <copyright file="ChenHolyPersuasion.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_chen
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.chen_holy_persuasion)]
    public class ChenHolyPersuasion : IAbilityComponent
    {
        [ImportingConstructor]
        public ChenHolyPersuasion([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.chen_holy_persuasion))
        {
        }

        public ChenHolyPersuasion(IServiceContext context, IAbilityComponent ability)
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