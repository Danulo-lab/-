namespace LR2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelResistivity;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelList;

        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.TextBox textBoxResistivity;
        private System.Windows.Forms.TextBox textBoxMaterial;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.ListBox listBoxWires;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelMarka = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelResistivity = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();

            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.textBoxResistivity = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();

            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();

            this.listBoxWires = new System.Windows.Forms.ListBox();

            this.SuspendLayout();
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 255);
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Name = "Form1";
            this.Text = "ЛР2 – Провід ЛЕП";
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Location = new System.Drawing.Point(20, 30);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(46, 15);
            this.labelMarka.Text = "Марка:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(150, 27);
            this.textBoxMarka.Size = new System.Drawing.Size(220, 23);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(20, 70);
            this.labelArea.Text = "Площа перерізу (мм²):";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(150, 67);
            this.textBoxArea.Size = new System.Drawing.Size(220, 23);
            // 
            // labelResistivity
            // 
            this.labelResistivity.AutoSize = true;
            this.labelResistivity.Location = new System.Drawing.Point(20, 110);
            this.labelResistivity.Text = "Питомий опір:";
            // 
            // textBoxResistivity
            // 
            this.textBoxResistivity.Location = new System.Drawing.Point(150, 107);
            this.textBoxResistivity.Size = new System.Drawing.Size(220, 23);
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(20, 150);
            this.labelMaterial.Text = "Матеріал:";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(150, 147);
            this.textBoxMaterial.Size = new System.Drawing.Size(220, 23);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 190);
            this.buttonAdd.Size = new System.Drawing.Size(100, 35);
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(74, 144, 226);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(140, 190);
            this.buttonClear.Size = new System.Drawing.Size(100, 35);
            this.buttonClear.Text = "Очистити";
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(74, 144, 226);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(20, 240);
            this.labelList.Text = "Список проводів:";
            // 
            // listBoxWires
            // 
            this.listBoxWires.FormattingEnabled = true;
            this.listBoxWires.ItemHeight = 15;
            this.listBoxWires.Location = new System.Drawing.Point(20, 260);
            this.listBoxWires.Size = new System.Drawing.Size(350, 150);
            // 
            // Add controls
            // 
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelResistivity);
            this.Controls.Add(this.textBoxResistivity);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBoxWires);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
