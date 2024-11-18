namespace Sueldo_neto_de_empleado_form
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
            calcular = new Button();
            sueldo = new TextBox();
            label1 = new Label();
            resultado = new TextBox();
            label2 = new Label();
            isrform = new TextBox();
            sfsform = new TextBox();
            afpform = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // calcular
            // 
            calcular.BackColor = SystemColors.ActiveCaption;
            calcular.FlatAppearance.BorderColor = Color.White;
            calcular.ForeColor = SystemColors.ActiveCaptionText;
            calcular.Location = new Point(183, 165);
            calcular.Name = "calcular";
            calcular.Size = new Size(194, 35);
            calcular.TabIndex = 0;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = false;
            calcular.Click += calcular_Click;
            // 
            // sueldo
            // 
            sueldo.Location = new Point(36, 113);
            sueldo.Name = "sueldo";
            sueldo.Size = new Size(194, 23);
            sueldo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 89);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 2;
            label1.Text = "Ingrese su sueldo mensual";
            // 
            // resultado
            // 
            resultado.Location = new Point(322, 113);
            resultado.Name = "resultado";
            resultado.Size = new Size(194, 23);
            resultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(322, 89);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 4;
            label2.Text = "Su sueldo neto es:";
            // 
            // isrform
            // 
            isrform.Location = new Point(70, 301);
            isrform.Name = "isrform";
            isrform.Size = new Size(100, 23);
            isrform.TabIndex = 5;
            // 
            // sfsform
            // 
            sfsform.Location = new Point(384, 301);
            sfsform.Name = "sfsform";
            sfsform.Size = new Size(100, 23);
            sfsform.TabIndex = 6;
            // 
            // afpform
            // 
            afpform.Location = new Point(231, 301);
            afpform.Name = "afpform";
            afpform.Size = new Size(100, 23);
            afpform.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(225, 245);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 8;
            label3.Text = "Otros detalles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(70, 279);
            label4.Name = "label4";
            label4.Size = new Size(28, 19);
            label4.TabIndex = 9;
            label4.Text = "ISR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(231, 279);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 10;
            label5.Text = "AFP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(384, 279);
            label6.Name = "label6";
            label6.Size = new Size(30, 19);
            label6.TabIndex = 11;
            label6.Text = "SFS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(110, 22);
            label7.Name = "label7";
            label7.Size = new Size(347, 25);
            label7.TabIndex = 12;
            label7.Text = "Calcular el sueldo neto de un empleado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 357);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(afpform);
            Controls.Add(sfsform);
            Controls.Add(isrform);
            Controls.Add(label2);
            Controls.Add(resultado);
            Controls.Add(label1);
            Controls.Add(sueldo);
            Controls.Add(calcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcular;
        private TextBox sueldo;
        private Label label1;
        private TextBox resultado;
        private Label label2;
        private TextBox isrform;
        private TextBox sfsform;
        private TextBox afpform;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
