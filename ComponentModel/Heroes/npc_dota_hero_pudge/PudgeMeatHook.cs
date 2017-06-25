// <copyright file="PudgeMeatHook.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Heroes.npc_dota_hero_pudge
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.ComponentModel.Components;
    using Ensage.SDK.Service;

    using SharpDX;

    [ExportAbilityComponent(AbilityId.pudge_meat_hook)]
    public class PudgeMeatHook : IAbilityComponent, ILineComponent, IRangedComponent
    {
        private IRangedComponent rangedComponentImplementation;

        [ImportingConstructor]
        public PudgeMeatHook([Import] IServiceContext context)
            : this(context, new AbilityComponent(context, AbilityId.pudge_meat_hook))
        {
        }

        public PudgeMeatHook(IServiceContext context, IAbilityComponent ability)
        {
            this.Context = context;
            this.Ability = ability;
        }

        public IAbilityComponent Ability { get; }

        public bool CanBeCasted
        {
            get
            {
                return this.rangedComponentImplementation.CanBeCasted;
            }
        }

        public float CastPoint
        {
            get
            {
                return this.rangedComponentImplementation.CastPoint;
            }
        }

        public IServiceContext Context { get; }

        public Ability Instance
        {
            get
            {
                return this.Ability.Instance;
            }
        }

        public bool IsActivated
        {
            get
            {
                return this.rangedComponentImplementation.IsActivated;
            }
        }

        public float Speed
        {
            get
            {
                return this.rangedComponentImplementation.Speed;
            }
        }

        public bool CanHit(params Unit[] targets)
        {
            return this.rangedComponentImplementation.CanHit(targets);
        }

        public int GetCastDelay()
        {
            return this.rangedComponentImplementation.GetCastDelay();
        }

        public int GetCastDelay(Unit target)
        {
            return this.rangedComponentImplementation.GetCastDelay(target);
        }

        public int GetCastDelay(Vector3 position)
        {
            return this.rangedComponentImplementation.GetCastDelay(position);
        }

        public float GetDamage(params Unit[] targets)
        {
            return this.rangedComponentImplementation.GetDamage(targets);
        }

        public int GetHitTime(Unit target)
        {
            return this.rangedComponentImplementation.GetHitTime(target);
        }

        public int GetHitTime(Vector3 position)
        {
            return this.rangedComponentImplementation.GetHitTime(position);
        }

        public bool UseAbility()
        {
            return this.rangedComponentImplementation.UseAbility();
        }

        public bool UseAbility(Rune target)
        {
            return this.rangedComponentImplementation.UseAbility(target);
        }

        public bool UseAbility(Tree target)
        {
            return this.rangedComponentImplementation.UseAbility(target);
        }

        public bool UseAbility(Unit target)
        {
            return this.rangedComponentImplementation.UseAbility(target);
        }

        public bool UseAbility(Vector3 position)
        {
            return this.rangedComponentImplementation.UseAbility(position);
        }
    }
}