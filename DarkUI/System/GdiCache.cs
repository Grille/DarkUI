using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DarkUI
{
    internal static class GdiCache
    {
        static readonly Dictionary<long, Pen> _pens;
        static readonly Dictionary<int, Brush> _brushs;

        public delegate void VoidEventHandler();

        public static event VoidEventHandler Invalidated;

        static GdiCache()
        {
            _pens = new();
            _brushs = new();
        }

        public static void Invalidate()
        {
            _pens.Clear();
            _brushs.Clear();

            Invalidated?.Invoke();
        }

        public static Brush Brush(Color color)
        {
            int key = color.ToArgb();
            if (_brushs.TryGetValue(key, out var brush))
            {
                return brush;
            }
            brush = new SolidBrush(color);
            _brushs[key] = brush;
            return brush;
        }

        public static Pen Pen(Color color)
        {
            return Pen(color, 1);
        }

        public static Pen Pen(Color color, int width)
        {
            long key = (uint)color.ToArgb() | (long)width << 32;
            if (_pens.TryGetValue(key, out var pen))
            {
                return pen;
            }
            pen = new Pen(color, width);
            _pens[key] = pen;
            return pen;
        }
    }
}
