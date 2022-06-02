
namespace GestPro
{
    partial class AjoutCommande
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ajout d\'une commande";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnnuler.Location = new System.Drawing.Point(534, 417);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(197, 23);
            this.btnAnnuler.TabIndex = 31;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btnValider.Location = new System.Drawing.Point(84, 417);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(197, 23);
            this.btnValider.TabIndex = 30;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(238, 204);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(47, 13);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Quantite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Identifiant produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Identifiant Employé";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(70, 197);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(151, 20);
            this.txtQuantite.TabIndex = 25;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(70, 149);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(151, 20);
            this.txtProd.TabIndex = 23;
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(70, 105);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(151, 20);
            this.txtEmp.TabIndex = 22;
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtEmp);
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AjoutCommande_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtEmp;
    }
}