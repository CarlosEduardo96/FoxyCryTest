using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace viruzinformaticoPrueba.exe
{
    class Cmd
    {
        public Cmd()
        { }
        public Cmd(string comando)
        {
            //mediante la libreria system.dianostic mando a llamar la clase ProcessStartInfo para ejecutar el cmd
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + comando);

            // Indicamos que la salida del proceso se redireccione en un Stream
           
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;

            //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
            procStartInfo.CreateNoWindow = true;
            //Inicializa el proceso
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
        }
    }
}
