using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    class PlaneComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name.Equals(nameof(Plane)) && y.GetType().Name.Equals(nameof(Seaplane)))
            {
                return 1;
            }
            else if (y.GetType().Name.Equals(nameof(Plane)) && x.GetType().Name.Equals(nameof(Seaplane)))
            {
                return -1;
            }
            else if (x.MaxSpeed <= y.MaxSpeed)
            {
                return 1;
            }
            if (x.MaxSpeed > y.MaxSpeed)
            {
                return -1;
            }
            return 0;
        }
        private int ComparerPlane(Plane x, Plane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSeaplane(Seaplane x, Seaplane y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.BottomSpoiler != y.BottomSpoiler)
            {
                return x.BottomSpoiler.CompareTo(y.BottomSpoiler);
            }
            if (x.ScrewSpoiler != y.ScrewSpoiler)
            {
                return x.ScrewSpoiler.CompareTo(y.ScrewSpoiler);
            }
            return 0;
        }
    }
}
