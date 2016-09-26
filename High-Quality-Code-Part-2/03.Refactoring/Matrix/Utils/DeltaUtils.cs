using System;

using MatrixHomework.Contracts;
using MatrixHomework.Models;

namespace MatrixHomework.Utils
{
    public class DeltaUtils
    {
        internal static IDelta GetDeltasByDirection(string direction)
        {
            switch (direction)
            {
                case "DownRight":
                    return new Delta() { X = 1, Y = 1 };
                case "Down":
                    return new Delta() { X = 1, Y = 0 };
                case "DownLeft":
                    return new Delta() { X = 1, Y = -1 };
                case "Left":
                    return new Delta() { X = 0, Y = -1 };
                case "UpLeft":
                    return new Delta() { X = -1, Y = -1 };
                case "Up":
                    return new Delta() { X = -1, Y = 0 };
                case "UpRight":
                    return new Delta() { X = -1, Y = 1 };
                case "Right":
                    return new Delta() { X = 0, Y = 1 };
                default:
                    throw new ArgumentException("Invalid direction!");
            }
        }
    }
}
