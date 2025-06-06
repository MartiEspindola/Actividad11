namespace ejemplo2
{
    partial class Form1
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
            btnRegistrar_Click = new Button();
            btnPromedio = new Button();
            tbValor = new TextBox();
            lbValor = new Label();
            lbPromedio = new Label();
            tbPromedio = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar_Click
            // 
            btnRegistrar_Click.Location = new Point(344, 75);
            btnRegistrar_Click.Name = "btnRegistrar_Click";
            btnRegistrar_Click.Size = new Size(75, 23);
            btnRegistrar_Click.TabIndex = 0;
            btnRegistrar_Click.Text = "Registrar";
            btnRegistrar_Click.UseVisualStyleBackColor = true;
            btnRegistrar_Click.Click += button1_Click;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(344, 122);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 38);
            btnPromedio.TabIndex = 1;
            btnPromedio.Text = "Calcular Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(161, 75);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(177, 23);
            tbValor.TabIndex = 3;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(117, 78);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 4;
            lbValor.Text = "Valor";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(117, 145);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(59, 15);
            lbPromedio.TabIndex = 5;
            lbPromedio.Text = "Promedio";
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(117, 175);
            tbPromedio.Multiline = true;
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(257, 85);
            tbPromedio.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 303);
            Controls.Add(tbPromedio);
            Controls.Add(lbPromedio);
            Controls.Add(lbValor);
            Controls.Add(tbValor);
            Controls.Add(btnPromedio);
            Controls.Add(btnRegistrar_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar_Click;
        private Button btnPromedio;
        private Button button3;
        private TextBox tbValor;
        private Label lbValor;
        private Label lbPromedio;
        private TextBox tbPromedio;
    }
}
