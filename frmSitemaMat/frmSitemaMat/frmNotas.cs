using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSitemaMat
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            dgvcursos.Rows.Add("Matematica", 0);
            dgvcursos.Rows.Add("Historia y Geografia", 0);
            dgvcursos.Rows.Add("Comunicacion", 0);
            dgvcursos.Rows.Add("Arte", 0);
            dgvcursos.Rows.Add("Educacion Fisica", 0);
        }
    }
}
