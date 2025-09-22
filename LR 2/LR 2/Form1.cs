using System;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.buttonAdd.Click += ButtonAdd_Click;
            this.buttonClear.Click += ButtonClear_Click;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Wire wire = new Wire();

                wire.Marka = textBoxMarka.Text.Trim();
                wire.Material = textBoxMaterial.Text.Trim();

                double area = double.Parse(textBoxArea.Text.Trim());
                double resistivity = double.Parse(textBoxResistivity.Text.Trim());

                wire.SetArea(area);
                wire.SetResistivity(resistivity);

                listBoxWires.Items.Add(wire.ToString());

                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
