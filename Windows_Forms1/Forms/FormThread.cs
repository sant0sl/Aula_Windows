using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms1.Forms
{
    public partial class FormThread : Form
    {
        private Thread myThread;
        private Thread myThreadLoad;

        public FormThread()
        {
            InitializeComponent();
            carregarThreads();
        }

        delegate void SetControlValueCallback(Control oControl, string propName, object propValue);
        private void SetControlPropertyValue(Control oControl, string propName, object propValue)
        {
            if (oControl.InvokeRequired)
            {
                SetControlValueCallback d = new SetControlValueCallback(SetControlPropertyValue);
                oControl.Invoke(d, new object[] { oControl, propName, propValue });
            }
            else
            {
                Type t = oControl.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propName.ToUpper())
                    {
                        p.SetValue(oControl, propValue, null);
                    }
                }
            }
        }

        private void FormThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            myThread.Abort();
            //myThreadLoad.Abort();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            myThreadLoad = new Thread(atualizaLoad);
            myThreadLoad.Start();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            myThread = new Thread(atualizaTela);
            myThread.Start();
        }

        public void atualizaTela()
        {
            while (true)
            {
                SetControlPropertyValue(lblNumeros, "Text", DateTime.Now.ToString("HH:mm:ss"));
            }
        }

        public void atualizaLoad()
        {
            for (int i = 0; i < 50000; i++)
            {
                SetControlPropertyValue(progressBar, "Value", i);
            }
        }

        public void carregarThreads()
        {
            myThread = new Thread(atualizaTela);
            myThread.Start();
            //myThreadLoad = new Thread(atualizaLoad);
            //myThreadLoad.Start();
        }
    }
}
