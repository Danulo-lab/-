// Form1.Designer.cs
namespace LR2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        private System.Windows.Forms.ListBox listBoxWires;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.listBoxWires = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.BackColor = System.Drawing.Color.Transparent;
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarka.ForeColor = System.Drawing.Color.Transparent;
            this.labelMarka.Location = new System.Drawing.Point(20, 30);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(138, 18);
            this.labelMarka.TabIndex = 0;
            this.labelMarka.Text = "Марка проводу :";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.BackColor = System.Drawing.Color.Transparent;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArea.ForeColor = System.Drawing.Color.White;
            this.labelArea.Location = new System.Drawing.Point(397, 28);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(184, 18);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Площа перерізу (мм²):";
            // 
            // labelResistivity
            // 
            this.labelResistivity.AutoSize = true;
            this.labelResistivity.BackColor = System.Drawing.Color.Transparent;
            this.labelResistivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResistivity.ForeColor = System.Drawing.Color.White;
            this.labelResistivity.Location = new System.Drawing.Point(20, 98);
            this.labelResistivity.Name = "labelResistivity";
            this.labelResistivity.Size = new System.Drawing.Size(187, 18);
            this.labelResistivity.TabIndex = 4;
            this.labelResistivity.Text = "Питомий опір (Ом/км):";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.BackColor = System.Drawing.Color.Transparent;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.ForeColor = System.Drawing.Color.White;
            this.labelMaterial.Location = new System.Drawing.Point(397, 96);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(85, 18);
            this.labelMaterial.TabIndex = 6;
            this.labelMaterial.Text = "Матеріал:";
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.BackColor = System.Drawing.Color.Transparent;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelList.ForeColor = System.Drawing.Color.Transparent;
            this.labelList.Location = new System.Drawing.Point(335, 222);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(146, 18);
            this.labelList.TabIndex = 10;
            this.labelList.Text = "Список проводів:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.AccessibleName = "";
            this.textBoxMarka.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxMarka.Location = new System.Drawing.Point(216, 28);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(167, 22);
            this.textBoxMarka.TabIndex = 1;
            this.textBoxMarka.Text = "Наприклад: АС-95/16";
            // 
            // textBoxArea
            // 
            this.textBoxArea.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxArea.Location = new System.Drawing.Point(593, 28);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(167, 22);
            this.textBoxArea.TabIndex = 3;
            this.textBoxArea.Text = "95.0";
            // 
            // textBoxResistivity
            // 
            this.textBoxResistivity.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxResistivity.Location = new System.Drawing.Point(216, 96);
            this.textBoxResistivity.Name = "textBoxResistivity";
            this.textBoxResistivity.Size = new System.Drawing.Size(167, 22);
            this.textBoxResistivity.TabIndex = 5;
            this.textBoxResistivity.Text = "0.306";
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxMaterial.Location = new System.Drawing.Point(593, 94);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(167, 22);
            this.textBoxMaterial.TabIndex = 7;
            this.textBoxMaterial.Text = "Алюміній/Сталь";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(168, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(413, 35);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Додати провід";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // listBoxWires
            // 
            this.listBoxWires.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxWires.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWires.FormattingEnabled = true;
            this.listBoxWires.ItemHeight = 16;
            this.listBoxWires.Location = new System.Drawing.Point(23, 257);
            this.listBoxWires.Name = "listBoxWires";
            this.listBoxWires.Size = new System.Drawing.Size(736, 144);
            this.listBoxWires.TabIndex = 11;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::LR_2.Properties.Resources._5aa651a2_99bd_4b00_b1ab_aefd96a1cfe2;
            this.ClientSize = new System.Drawing.Size(771, 412);
            this.Controls.Add(this.labelMarka);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelResistivity);
            this.Controls.Add(this.textBoxResistivity);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBoxWires);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Провід ЛЕП";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
