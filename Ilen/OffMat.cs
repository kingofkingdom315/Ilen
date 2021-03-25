using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilen
{
    public partial class OffMat : Form
    {
        public OffMat(List<object> li)
        {
            InitializeComponent();

            this.Fill(li);
        }

        public void Fill(List<MaterialOff> li)
        {
            all_off_mat_list.Items.Clear();

            foreach (MaterialOff m in li)
            {
                all_off_mat_list.Items.Add(m);
            }
        }

        public void Fill(List<MaterialOff> li)
        {
            all_off_mat_list.Items.Clear();

            foreach (MaterialOff m in li)
            {
                all_off_mat_list.Items.Add(m);
            }
        }
    }
}
