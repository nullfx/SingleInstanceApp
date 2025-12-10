using System.Windows.Forms;

namespace SingleInstanceApp {
    public partial class Form1 : Form {
        public Form1 ( ) {
            InitializeComponent ( );
        }

        protected override void WndProc ( ref Message m ) {
            // handle the WM_SHOWME message and bring 
            // this window to the top
            if ( m.Msg == NativeMethods.WM_SHOWME ) {
                ShowMe ( );
            }
            base.WndProc ( ref m );
        }

        private void ShowMe ( ) {
            if ( WindowState == FormWindowState.Minimized ) {
                WindowState = FormWindowState.Normal;
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }

        private void HandleExitClick ( object sender, System.EventArgs e ) {
            Close ( );
        }
    }
}
