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
    public partial class ParentForm : Form
    {
        public Person person = new Person(); // створюєсо обєкту класу
        public string Nameform // властивість для відображення тексту в textBox1 в батьківському класі
        {
            get
            { return textBox1.Text; }
            set
            { textBox1.Text = value; }
        }
        public ParentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // обробка кнопки "Редагувати"
        {
            // Звязуємо батьківську форму з дитячою
            ChildForm childForm = new ChildForm(); // створ. обєкт класу форми дитини
            childForm.ParentFormParent = this; // підвязуємо батьківську форму дитині

            if (childForm.ShowDialog() == DialogResult.OK) //при виводі діалогового вікна дитини, перевіряємо чи натиснуто кнопку ОК (властивість DialogResult ставимо OK)
            {
                textBox1.Text = person.Name; //Якщо ОК натиснуто, то тоді перезаписуємо значення, якщо ОК не натиснуто (наприклад вікно закриється), то перезапису не відбудеться
                label3.Text = person.SurName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.Phone, "Number telephone"); 
        }

    }
}
