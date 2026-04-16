using System;
using System.Collections.Generic;
using System.Text;

namespace KakeForm
{
    public interface ICargo
    {
        bool ValidateDestination(Truck.TruckType truck);
        List<string> MakeCargo();
        void ConstructCargo(List<string> list);
    }
}
