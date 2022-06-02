
namespace GestPro
{
    partial class ModProd
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
            this.lblIdF = new System.Windows.Forms.Label();
            this.txtIdF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrixV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrixA = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdF
            // 
            this.lblIdF.AutoSize = true;
            this.lblIdF.Location = new System.Drawing.Point(238, 308);
            this.lblIdF.Name = "lblIdF";
            this.lblIdF.Size = new System.Drawing.Size(122, 13);
            this.lblIdF.TabIndex = 51;
            this.lblIdF.Text = "Identifiant du fournisseur";
            // 
            // txtIdF
            // 
            this.txtIdF.Location = new System.Drawing.Point(70, 301);
            this.txtIdF.Name = "txtIdF";
            this.txtIdF.Size = new System.Drawing.Size(151, 20);
            this.txtIdF.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Prix de vente";
            // 
            // txtPrixV
            // 
            this.txtPrixV.Location = new System.Drawing.Point(70, 264);
            this.txtPrixV.Name = "txtPrixV";
            this.txtPrixV.Size = new System.Drawing.Size(151, 20);
            this.txtPrixV.TabIndex = 48;
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
            this.label5.Size = new System.Drawing.Size(263, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Modification d\'un produit";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnnuler.Location = new System.Drawing.Point(534, 417);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(197, 23);
            this.btnAnnuler.TabIndex = 46;
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
            this.btnValider.TabIndex = 45;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Prix d\'achat";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(238, 196);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 43;
            this.lblStock.Text = "Stock";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(238, 156);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(94, 13);
            this.lblPoids.TabIndex = 42;
            this.lblPoids.Text = "Poids (en gramme)";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(238, 112);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(37, 13);
            this.lblLabel.TabIndex = 41;
            this.lblLabel.Text = "Libellé";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(70, 189);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(151, 20);
            this.txtStock.TabIndex = 40;
            // 
            // txtPrixA
            // 
            this.txtPrixA.Location = new System.Drawing.Point(70, 226);
            this.txtPrixA.Name = "txtPrixA";
            this.txtPrixA.Size = new System.Drawing.Size(151, 20);
            this.txtPrixA.TabIndex = 39;
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(70, 149);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(151, 20);
            this.txtPoids.TabIndex = 38;
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(70, 105);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(151, 20);
            this.txtLabel.TabIndex = 37;
            // 
            // ModProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdF);
            this.Controls.Add(this.txtIdF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrixV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrixA);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.txtLabel);
            this.Name = "ModProd";
            this.Text = "ModProd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModProd_FormClosed);
            this.Load += new System.EventHandler(this.ModProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdF;
        private System.Windows.Forms.TextBox txtIdF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrixA;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtLabel;
    }
}