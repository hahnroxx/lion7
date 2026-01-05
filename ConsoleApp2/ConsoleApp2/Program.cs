using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    const int STD_OUTPUT_HANDLE = -11;
    const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

    static void EnableVT()
    {
        var h = GetStdHandle(STD_OUTPUT_HANDLE);
        if (h == IntPtr.Zero) return;
        if (!GetConsoleMode(h, out uint mode)) return;
        SetConsoleMode(h, mode | ENABLE_VIRTUAL_TERMINAL_PROCESSING);
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;

        EnableVT();

        int width = 61;
        int height = 31;

        int cx = width / 2;
        int cy = height / 2;

        double aspect = 2.0;
        double thickness = 0.55;

        int r1 = 5, r2 = 10, r3 = 15;

        double starX = cx + r3 * aspect;
        double starY = cy - r3;

        double step = 0.55;
        bool blinkOn = true;

        double dist = 1.2;
        while (dist >= 1.2)
        {
            double vx = cx - starX;
            double vy = cy - starY;
            dist = Math.Sqrt(vx * vx + vy * vy);

            double nx = vx / dist;
            double ny = vy / dist;
            starX += nx * step;
            starY += ny * step;

            blinkOn = !blinkOn;

            char[,] buf = new char[height, width];

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    buf[y, x] = '.';

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double dx = (x - cx) / aspect;
                    double dy = (y - cy);
                    double d = Math.Sqrt(dx * dx + dy * dy);

                    if (Math.Abs(d - r1) < thickness ||
                        Math.Abs(d - r2) < thickness ||
                        Math.Abs(d - r3) < thickness)
                        buf[y, x] = 'O';
                }
            }

            for (int x = 0; x < width; x++) buf[cy, x] = '-';
            for (int y = 0; y < height; y++) buf[y, cx] = '|';
            buf[cy, cx] = '+';

            int sx = (int)Math.Round(starX);
            int sy = (int)Math.Round(starY);
            if (blinkOn && sy >= 0 && sy < height && sx >= 0 && sx < width)
                buf[sy, sx] = '*';

            var sb = new StringBuilder(height * (width + 2));
            sb.Append("\x1b[H\x1b[2J");

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    sb.Append(buf[y, x]);
                if (y != height - 1) sb.Append('\n');
            }

            Console.Write(sb.ToString());
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}