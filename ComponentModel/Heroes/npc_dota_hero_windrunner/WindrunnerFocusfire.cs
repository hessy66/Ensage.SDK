// <copyright file="WindrunnerFocusfire.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_windrunner
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.windrunner_focusfire)]
    public class WindrunnerFocusfire : IAbilityComponent
    {
        [ImportingConstructor]
        public WindrunnerFocusfire([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.windrunner_focusfire))
        {
        }

        public WindrunnerFocusfire(IServiceContext context, IAbilityComponent ability)
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