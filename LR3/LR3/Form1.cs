using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.buttonAdd.Click += ButtonAdd_Click;
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string marka = textBoxMarka.Text.Trim();
            string area = textBoxArea.Text.Trim();
            string resistivity = textBoxResistivity.Text.Trim();
            string material = textBoxMaterial.Text.Trim();


            if (string.IsNullOrEmpty(marka) ||
                string.IsNullOrEmpty(area) ||
                string.IsNullOrEmpty(resistivity) ||
                string.IsNullOrEmpty(material))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string wireInfo = $"Марка: {marka}, Площа: {area} мм², Опір: {resistivity}, Матеріал: {material}";


            listBoxWires.Items.Add(wireInfo);


            ClearTextBoxes();
        }


        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            textBoxMarka.Clear();
            textBoxArea.Clear();
            textBoxResistivity.Clear();
            textBoxMaterial.Clear();
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}