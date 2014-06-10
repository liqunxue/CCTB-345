using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindSystem.BLL;

namespace DesktopApp
{
    public partial class ViewRegions : Form
    {
        public ViewRegions()
        {
            InitializeComponent();
        }

        private void ViewRegions_Load(object sender, EventArgs e)
        {
            // Populate the comboBox
            NorthwindManager manager = new NorthwindManager();
            var data = manager.GetRegions();
            cboRegions.DataSource =data;
            cboRegions.DisplayMember = "RegionDescription";
            cboRegions.ValueMember = "RegionID";
        }
    }
}
