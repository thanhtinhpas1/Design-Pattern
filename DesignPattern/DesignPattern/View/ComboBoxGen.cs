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
    public partial class ComboBoxGen : Form
    {
        string[] classes = { "ctt1", "ctt2", "ctt3", "ctt4" };

        public ComboBoxGen()
        {
            InitializeComponent();
            foreach(var item in classes)
            {
                cbGen.Items.Add(item);
            }
        }
    }
}
