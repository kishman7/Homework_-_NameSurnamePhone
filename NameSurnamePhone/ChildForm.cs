using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSurnamePhone
{
    public partial class ChildForm : Form
    {
        public ParentForm ParentFormParent { get; set; } // створення властивості батьківського класу, через який будемо підвязуватись до батьківської форми
        public ChildForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParentFormParent.person.Name = textBox1.Text;
            ParentFormParent.person.SurName = textBox2.Text;
            ParentFormParent.person.Phone = textBox3.Text;
            Close();

        }

        private void ChildForm_Shown(object sender, EventArgs e) // визивається подію, яка спрацьовує, коли форма буде показано
        {
            textBox1.Text = ParentFormParent.Nameform; // перезаписуємо значення в textBox1 в батьківську форму
        }
    }
}
