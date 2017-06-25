// <copyright file="ActiveComponent.cs" company="Ensage">
//    Copyright (c) 2017 Ensage.
// </copyright>

namespace Ensage.SDK.ComponentModel.Components
{
    using System;

    using SharpDX;

    public class ActiveComponent : IActiveComponent
    {
        public bool CanBeCasted { get; }

        public float CastPoint { get; }

        public bool IsActivated { get; }

        public float Speed { get; }

        public bool CanHit(params Unit[] targets)
        {
            throw new NotImplementedException();
        }

        public int GetCastDelay()
        {
            throw new NotImplementedException();
        }

        public int GetCastDelay(Unit target)
        {
            throw new NotImplementedException();
        }

        public int GetCastDelay(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public float GetDamage(params Unit[] targets)
        {
            throw new NotImplementedException();
        }

        public int GetHitTime(Unit target)
        {
            throw new NotImplementedException();
        }

        public int GetHitTime(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public bool UseAbility()
        {
            throw new NotImplementedException();
        }

        public bool UseAbility(Rune target)
        {
            throw new NotImplementedException();
        }

        public bool UseAbility(Tree target)
        {
            throw new NotImplementedException();
        }

        public bool UseAbility(Unit target)
        {
            throw new NotImplementedException();
        }

        public bool UseAbility(Vector3 position)
        {
            throw new NotImplementedException();
        }
    }
}