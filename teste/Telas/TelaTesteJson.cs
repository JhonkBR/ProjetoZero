using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste.Json;

namespace teste.Telas
{
    public partial class TelaTesteJson : Form
    {
        public TelaTesteJson()
        {
            InitializeComponent();
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText(@"C:\Users\jhonata.teles\Desktop\teste\teste\Json\Teste.Json");
            var pessoas2 = JsonConvert.DeserializeObject<List<Pessoa>>(json);

        }

        private void TelaTesteJson_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Sistema online");
        }
    }
}
