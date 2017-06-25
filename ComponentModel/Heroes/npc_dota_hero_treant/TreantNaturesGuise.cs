// <copyright file="TreantNaturesGuise.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_treant
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    [ExportAbilityComponent(AbilityId.treant_natures_guise)]
    public class TreantNaturesGuise : IAbilityComponent
    {
        [ImportingConstructor]
        public TreantNaturesGuise([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.treant_natures_guise))
        {
        }

        public TreantNaturesGuise(IServiceContext context, IAbilityComponent ability)
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