using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kepler7.Core.Juego;

namespace Kepler7.Game
{
    internal static class Sesion
    {
        public static Progreso Progreso { get; private set; } = Persistencia.Cargar();

        public static void Guardar() => Persistencia.Guardar(Progreso);

        public static void NuevaPartida()
        {
            Progreso = new Progreso { TutorialVisto = true };
            Guardar();
        }

        public static void Dominar(Form area, string patron)
        {
            if (Progreso.Terminada || !Progreso.Dominar(patron))
                return;

            Guardar();
            Ui.MostrarLogro(area, "LOGRO: " + patron + " dominado  (+100 XP)");

            if (Progreso.Victoria)
            {
                MessageBox.Show(area, "¡Dominaste los 12 patrones! Kepler-7 está a salvo.", "VICTORIA",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                area.DialogResult = DialogResult.Abort;  
            }
        }

        public static void Perder(Form area, string motivo)
        {
            if (Progreso.Terminada)
                return;

            Progreso.Derrota = true;
            Progreso.MotivoDerrota = motivo;
            Guardar();
            MessageBox.Show(area, motivo, "DERROTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            area.DialogResult = DialogResult.Abort;
        }
    }
}
