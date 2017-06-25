// <copyright file="AreaOfEffectComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System.ComponentModel.Composition;

    using Ensage.SDK.Extensions;
    using Ensage.SDK.Service;

    using PlaySharp.Toolkit.Helper.Annotations;

    using SharpDX;

    public class AreaOfEffectComponent : RangedComponent, IAreaOfEffectComponent
    {
        public AreaOfEffectComponent([NotNull] IServiceContext context, [NotNull] Ability ability)
            : base(context, ability)
        {
        }

        public bool CanBeCasted
        {
            get
            {
                return this.RangedComponent.CanBeCasted;
            }
        }

        public float CastPoint
        {
            get
            {
                return this.RangedComponent.CastPoint;
            }
        }

        public bool IsActivated
        {
            get
            {
                return this.RangedComponent.IsActivated;
            }
        }

        public virtual float Radius
        {
            get
            {
                return this.Instance.GetAbilitySpecialData(this.RadiusName);
            }
        }

        public string RadiusName { get; } = "radius";

        public float Speed
        {
            get
            {
                return this.RangedComponent.Speed;
            }
        }

        [Import(typeof(IRangedComponent))]
        protected IRangedComponent RangedComponent { get; set; }

        public bool CanHit(params Unit[] targets)
        {
            return this.RangedComponent.CanHit(targets);
        }

        public int GetCastDelay()
        {
            return this.RangedComponent.GetCastDelay();
        }

        public int GetCastDelay(Unit target)
        {
            return this.RangedComponent.GetCastDelay(target);
        }

        public int GetCastDelay(Vector3 position)
        {
            return this.RangedComponent.GetCastDelay(position);
        }

        public float GetDamage(params Unit[] targets)
        {
            return this.RangedComponent.GetDamage(targets);
        }

        public int GetHitTime(Unit target)
        {
            return this.RangedComponent.GetHitTime(target);
        }

        public int GetHitTime(Vector3 position)
        {
            return this.RangedComponent.GetHitTime(position);
        }

        public bool UseAbility()
        {
            return this.RangedComponent.UseAbility();
        }

        public bool UseAbility(Rune target)
        {
            return this.RangedComponent.UseAbility(target);
        }

        public bool UseAbility(Tree target)
        {
            return this.RangedComponent.UseAbility(target);
        }

        public bool UseAbility(Unit target)
        {
            return this.RangedComponent.UseAbility(target);
        }

        public bool UseAbility(Vector3 position)
        {
            return this.RangedComponent.UseAbility(position);
        }
    }
}