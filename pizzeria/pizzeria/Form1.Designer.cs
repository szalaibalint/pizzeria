namespace pizzeria
{
    partial class PizzaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.lblFizetendo = new System.Windows.Forms.Label();
            this.txtFizetendo = new System.Windows.Forms.TextBox();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlKozponti = new System.Windows.Forms.Panel();
            this.lblMenuvalasztek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(58, 339);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 10;
            this.btnSzamol.Text = "Szamol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(58, 386);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // lblFizetendo
            // 
            this.lblFizetendo.AutoSize = true;
            this.lblFizetendo.BackColor = System.Drawing.Color.Transparent;
            this.lblFizetendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFizetendo.ForeColor = System.Drawing.Color.Tomato;
            this.lblFizetendo.Location = new System.Drawing.Point(156, 342);
            this.lblFizetendo.Name = "lblFizetendo";
            this.lblFizetendo.Size = new System.Drawing.Size(79, 16);
            this.lblFizetendo.TabIndex = 12;
            this.lblFizetendo.Text = "Fizetendő:";
            // 
            // txtFizetendo
            // 
            this.txtFizetendo.Location = new System.Drawing.Point(233, 341);
            this.txtFizetendo.Name = "txtFizetendo";
            this.txtFizetendo.ReadOnly = true;
            this.txtFizetendo.Size = new System.Drawing.Size(100, 20);
            this.txtFizetendo.TabIndex = 13;
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(213, 386);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(148, 23);
            this.btnAdatBe.TabIndex = 14;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(447, 386);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 15;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlKozponti
            // 
            this.pnlKozponti.AutoScroll = true;
            this.pnlKozponti.BackColor = System.Drawing.Color.Bisque;
            this.pnlKozponti.Location = new System.Drawing.Point(58, 71);
            this.pnlKozponti.Name = "pnlKozponti";
            this.pnlKozponti.Size = new System.Drawing.Size(464, 221);
            this.pnlKozponti.TabIndex = 16;
            // 
            // lblMenuvalasztek
            // 
            this.lblMenuvalasztek.AutoSize = true;
            this.lblMenuvalasztek.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuvalasztek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMenuvalasztek.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblMenuvalasztek.Location = new System.Drawing.Point(157, 23);
            this.lblMenuvalasztek.Name = "lblMenuvalasztek";
            this.lblMenuvalasztek.Size = new System.Drawing.Size(264, 31);
            this.lblMenuvalasztek.TabIndex = 17;
            this.lblMenuvalasztek.Text = "MENÜVÁLASZTÉK";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImage = global::pizzeria.Properties.Resources.pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.Controls.Add(this.lblMenuvalasztek);
            this.Controls.Add(this.pnlKozponti);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.txtFizetendo);
            this.Controls.Add(this.lblFizetendo);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzéria próba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Label lblFizetendo;
        private System.Windows.Forms.TextBox txtFizetendo;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnlKozponti;
        private System.Windows.Forms.Label lblMenuvalasztek;
    }
}

