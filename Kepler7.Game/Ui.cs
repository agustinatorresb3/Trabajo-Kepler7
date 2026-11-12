using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kepler7.Game
{
    internal class Ui
    {
        public static void MostrarLogro(Form f, string texto)
        {
            var cartel = new Label
            {
                Text = "★ " + texto + " ★",
                Location = new Point(0, 0),
                Size = new Size(f.ClientSize.Width, 36),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.Gold,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold)
            };

            f.Controls.Add(cartel);
            cartel.BringToFront();

            int ticks = 0;
            var timer = new Timer { Interval = 250 };
            timer.Tick += (s, e) =>
            {
                if (cartel.IsDisposed || ++ticks > 12)
                {
                    timer.Dispose();
                    cartel.Dispose();
                    return;
                }
                cartel.BackColor = ticks % 2 == 0 ? Color.Gold : Color.Orange;
            };
            timer.Start();
        }
    }
}