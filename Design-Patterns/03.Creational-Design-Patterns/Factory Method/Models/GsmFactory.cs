using System;

using Factory_Method.Contracts;
using Factory_Method.Enums;

namespace Factory_Method.Models
{
    /// <summary>
    /// Implementation of Factory - Used to create Phones
    /// </summary>
    public class GsmFactory
    {
        public IGsm CreateGsm(GsmModel model)
        {
            switch (model)
            {
                case GsmModel.IPhone:
                    return new IPhone();
                case GsmModel.Galaxy:
                    return new SamsungGalaxy();
                default:
                    throw new NotSupportedException("model");
            }
        }
    }
}
