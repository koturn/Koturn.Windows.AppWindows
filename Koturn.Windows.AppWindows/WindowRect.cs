using System.Runtime.InteropServices;


namespace Koturn.Windows.AppWindows
{
    /// <summary>
    /// Structure which represents window rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowRect
    {
        /// <summary>
        /// x position of upper-left corner.
        /// </summary>
        public int Left { get; set; }
        /// <summary>
        /// y position of upper-left corner.
        /// </summary>
        public int Top { get; set; }
        /// <summary>
        /// x position of lower-right corner.
        /// </summary>
        public int Right { get; set; }
        /// <summary>
        /// y position of lower-right corner.
        /// </summary>
        public int Bottom { get; set; }
        /// <summary>
        /// Alias of <see cref="Left"/>.
        /// </summary>
        public readonly int X => Left;
        /// <summary>
        /// Alias of <see cref="Top"/>.
        /// </summary>
        public readonly int Y => Top;
        /// <summary>
        /// Width of rectangle.
        /// </summary>
        public readonly int Width => Right - Left;
        /// <summary>
        /// Height of rectangle.
        /// </summary>
        public readonly int Height => Bottom - Top;

        /// <summary>
        /// Create <see cref="WindowRect"/> instance.
        /// </summary>
        /// <param name="left">x position of upper-left corner.</param>
        /// <param name="top">y position of upper-left corner.</param>
        /// <param name="right">x position of lower-right corner.</param>
        /// <param name="bottom">y position of lower-right corner.</param>
        public WindowRect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }
    }
}
