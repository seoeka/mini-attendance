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

namespace Mini_Attendance.Projects.user_controls
{
    public partial class UserControlEvent : UserControl
    {

        private SqlConnection connection;
        private int selectedEventID;

        public UserControlEvent()
        {
            InitializeComponent();
        }
    }
}
