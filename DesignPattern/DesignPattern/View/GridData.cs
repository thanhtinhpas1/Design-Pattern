using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.View
{
    public partial class GridData : Form
    {
        public string[] columns = { "id", "name", "class", "start_date", "end_date" };
        public string[] student1 = { "1", "tinh", "ctt5", "11/11/2019", "11/11/2019" };

        public GridData()
        {
            InitializeComponent();
            retrieveData();
        }

        void retrieveData()
        {
           foreach(var item in this.columns)
            {
                dtgGen1.Columns.Add("Column", item);
            }
           for (int i = 0; i < 10; i++)
            {
                dtgGen1.Rows.Add(student1);
            }
        }
    }
}
