using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms1.Forms
{
    public partial class ExecutarArquivos : Form
    {
        public ExecutarArquivos()
        {
            InitializeComponent();
        }

        private void btnNavegador_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "chrome.exe";
            process.StartInfo.Arguments = "http://www.unifacear.edu.br/";
            process.Start();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            string dir = @"C:\Users\sant0\Desktop\Facear.txt";
            process.StartInfo.Arguments = dir;
            process.Start();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            string dir = @"C:\Users\sant0\OneDrive\Arquivos\Tudo\Música mic\2.mp3";
            process.StartInfo.FileName = dir;
            process.Start();
        }
    }
}
