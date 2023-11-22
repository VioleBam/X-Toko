using System;
using System.Threading;
using System.Windows.Forms;

namespace X_Toko
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());*/
	        Mutex mutex = new Mutex(false, "X-Toko.exe");
    	    try
    	    {
        		if (mutex.WaitOne(0, false))
            	{
                	// Run the application
                	Application.EnableVisualStyles();
                	Application.SetCompatibleTextRenderingDefault(false);
                	Application.Run(new frmMain());
            	}
            	else
            	{
                	MessageBox.Show("Aplikasi X-Toko sudah dijalankan. Cek System Tray.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            	}
            }
    	    finally
    	    {
        	    if (mutex != null)
        	    {
            	    	mutex.Close();
            	        mutex = null;
        	    }
            }
        }
    }
}
