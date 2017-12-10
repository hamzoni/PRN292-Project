using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectCSharp.Middleware
{
    public class MultiFormContext : ApplicationContext
    {
        /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MultiFormContext(new Form1(), new Form2()));
         */
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }
}
