namespace ProyectoYoga_PixelPulse
{
    partial class DiccionarioYoga
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiccionarioYoga));
            BusquedaTextBox = new TextBox();
            label1 = new Label();
            BusquedaButton = new Button();
            ESTextBox = new TextBox();
            ENTextBox = new TextBox();
            MorfemaTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // BusquedaTextBox
            // 
            BusquedaTextBox.Location = new Point(217, 81);
            BusquedaTextBox.Margin = new Padding(3, 2, 3, 2);
            BusquedaTextBox.Name = "BusquedaTextBox";
            BusquedaTextBox.Size = new Size(234, 23);
            BusquedaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Sitka Banner", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(236, 43);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 1;
            label1.Text = "Diccionario de asanas";
            // 
            // BusquedaButton
            // 
            BusquedaButton.Image = (Image)resources.GetObject("BusquedaButton.Image");
            BusquedaButton.Location = new Point(456, 71);
            BusquedaButton.Margin = new Padding(3, 2, 3, 2);
            BusquedaButton.Name = "BusquedaButton";
            BusquedaButton.Size = new Size(46, 39);
            BusquedaButton.TabIndex = 2;
            BusquedaButton.UseVisualStyleBackColor = true;
            BusquedaButton.Click += BuscarCoincidencia;
            // 
            // ESTextBox
            // 
            ESTextBox.BorderStyle = BorderStyle.FixedSingle;
            ESTextBox.Location = new Point(57, 151);
            ESTextBox.Margin = new Padding(3, 2, 3, 2);
            ESTextBox.Multiline = true;
            ESTextBox.Name = "ESTextBox";
            ESTextBox.ReadOnly = true;
            ESTextBox.Size = new Size(250, 128);
            ESTextBox.TabIndex = 3;
            // 
            // ENTextBox
            // 
            ENTextBox.BorderStyle = BorderStyle.FixedSingle;
            ENTextBox.Location = new Point(346, 151);
            ENTextBox.Margin = new Padding(3, 2, 3, 2);
            ENTextBox.Multiline = true;
            ENTextBox.Name = "ENTextBox";
            ENTextBox.ReadOnly = true;
            ENTextBox.Size = new Size(250, 128);
            ENTextBox.TabIndex = 4;
            ENTextBox.TextChanged += ENTextBox_TextChanged;
            // 
            // MorfemaTextBox
            // 
            MorfemaTextBox.BorderStyle = BorderStyle.FixedSingle;
            MorfemaTextBox.Location = new Point(129, 317);
            MorfemaTextBox.Margin = new Padding(3, 2, 3, 2);
            MorfemaTextBox.Multiline = true;
            MorfemaTextBox.Name = "MorfemaTextBox";
            MorfemaTextBox.ReadOnly = true;
            MorfemaTextBox.Size = new Size(374, 128);
            MorfemaTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 124);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 6;
            label2.Text = "Español";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(346, 124);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 7;
            label3.Text = "Inglés";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(129, 290);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 8;
            label4.Text = "Morfemas ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // DiccionarioYoga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 477);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MorfemaTextBox);
            Controls.Add(ENTextBox);
            Controls.Add(ESTextBox);
            Controls.Add(BusquedaButton);
            Controls.Add(label1);
            Controls.Add(BusquedaTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "DiccionarioYoga";
            Text = "YogaPose Translate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BusquedaTextBox;
        private Label label1;
        private Button BusquedaButton;
        private TextBox ESTextBox;
        private TextBox ENTextBox;
        private TextBox MorfemaTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
    }
}