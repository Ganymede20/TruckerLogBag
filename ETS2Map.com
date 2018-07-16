using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trucker_Log_Bag
{
    public partial class ETS2Map: Form
    {
        public ETS2Map()
        {
            InitializeComponent();
        }
    }
}
