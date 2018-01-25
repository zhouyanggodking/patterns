using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class WeaponDecorator : IWeapon
    {
        protected IWeapon _weapon; //interface oriented programming

        public void SetWeapon(IWeapon weapon)
        {
            this._weapon = weapon;
        }

        public virtual void Move()
        {
            if (null != this._weapon)
                this._weapon.Move();
        }

        public virtual void Destroy()
        {
            if (null != this._weapon)
                this._weapon.Destroy();
        }
    }
}
