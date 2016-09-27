using System;
using System.Runtime.CompilerServices;

using MatrixHomework.Contracts;
using MatrixHomework.Models;

[assembly:InternalsVisibleTo("Matrix.Tests")]
namespace MatrixHomework.Utils
{
    /// <summary>
    /// Helpers for the class <see cref="Delta"/>.
    /// </summary>
    public class DeltaUtils
    {
        /// <summary>
        /// Returns <see cref="IDelta"/> with specific X and Y values for the current direction.
        /// </summary>
        /// <param name="direction">Current direction.</param>
        /// <returns>Returns <see cref="IDelta"/></returns>
        /// <exception cref="ArgumentException"/>
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
