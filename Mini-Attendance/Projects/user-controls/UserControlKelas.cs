using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mini_Attendance.form.main;

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlKelas : UserControl, IUserControlClearAndDisable
    {
        private SqlConnection connection;
        public UserControlKelas()
        {
            InitializeComponent();
        }

        public void ClearAndDisable()
        {
            TextBoxHelper.ClearTextBoxes(textBoxNM, textBoxNI, textBoxEM, textBoxPW,
                                         textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
            TextBoxHelper.EnableTextBoxes(false, textBoxNM1, textBoxNI1, textBoxEM1, textBoxPW1);
            btEdi.Enabled = false;
            btDel.Enabled = false;
        }
    }
}
