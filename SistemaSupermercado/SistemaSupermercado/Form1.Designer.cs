namespace SistemaSupermercado
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
            panelLateral = new Panel();
            btn3Menu = new Button();
            btn2Menu = new Button();
            btn1Menu = new Button();
            label2 = new Label();
            label1 = new Label();
            panelPrincipal = new Panel();
            panelLateral.SuspendLayout();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.CornflowerBlue;
            panelLateral.Controls.Add(btn3Menu);
            panelLateral.Controls.Add(btn2Menu);
            panelLateral.Controls.Add(btn1Menu);
            panelLateral.Controls.Add(label2);
            panelLateral.Controls.Add(label1);
            panelLateral.Location = new Point(1, 1);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(200, 521);
            panelLateral.TabIndex = 0;
            // 
            // btn3Menu
            // 
            btn3Menu.BackColor = Color.Gainsboro;
            btn3Menu.FlatAppearance.BorderColor = Color.Black;
            btn3Menu.FlatStyle = FlatStyle.Popup;
            btn3Menu.Font = new Font("Segoe UI", 12F);
            btn3Menu.Location = new Point(43, 247);
            btn3Menu.Name = "btn3Menu";
            btn3Menu.Size = new Size(120, 36);
            btn3Menu.TabIndex = 4;
            btn3Menu.Text = "Sair";
            btn3Menu.UseVisualStyleBackColor = false;
            // 
            // btn2Menu
            // 
            btn2Menu.BackColor = Color.Gainsboro;
            btn2Menu.FlatAppearance.BorderColor = Color.Black;
            btn2Menu.FlatStyle = FlatStyle.Popup;
            btn2Menu.Font = new Font("Segoe UI", 12F);
            btn2Menu.Location = new Point(43, 188);
            btn2Menu.Name = "btn2Menu";
            btn2Menu.Size = new Size(120, 36);
            btn2Menu.TabIndex = 3;
            btn2Menu.Text = "Compras";
            btn2Menu.UseVisualStyleBackColor = false;
            // 
            // btn1Menu
            // 
            btn1Menu.BackColor = Color.Gainsboro;
            btn1Menu.FlatAppearance.BorderColor = Color.Black;
            btn1Menu.FlatStyle = FlatStyle.Popup;
            btn1Menu.Font = new Font("Segoe UI", 12F);
            btn1Menu.Location = new Point(43, 131);
            btn1Menu.Name = "btn1Menu";
            btn1Menu.Size = new Size(120, 36);
            btn1Menu.TabIndex = 2;
            btn1Menu.Text = "Produtos";
            btn1Menu.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(43, 49);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Gestão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(2, 24);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Supermercado";
            // 
            // panelPrincipal
            // 
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(938, 522);
            panelPrincipal.TabIndex = 1;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 522);
            Controls.Add(panelLateral);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Panel panelPrincipal;
        private Label label1;
        private Button btn2Menu;
        private Button btn1Menu;
        private Label label2;
        private Button btn3Menu;
    }
}
