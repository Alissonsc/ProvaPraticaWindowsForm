namespace ProvaPratica
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
            label1 = new Label();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            lblTelefone = new Label();
            lblNome = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(121, 52);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 17;
            label1.Text = "CADASTRO";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(121, 214);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(180, 23);
            txtTelefone.TabIndex = 16;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 150);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 15;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(121, 196);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 14;
            lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(121, 132);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(172, 278);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 352);
            Controls.Add(label1);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private Label lblTelefone;
        private Label lblNome;
        private Button btnSalvar;
    }
}
