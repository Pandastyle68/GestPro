
namespace GestPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblGestPro = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.btnConsPostes = new System.Windows.Forms.Button();
            this.btnConsFour = new System.Windows.Forms.Button();
            this.btnConsFid = new System.Windows.Forms.Button();
            this.btnConsProd = new System.Windows.Forms.Button();
            this.btnConsCom = new System.Windows.Forms.Button();
            this.btnConsEmp = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "GestPro";
            // 
            // lblGestPro
            // 
            this.lblGestPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestPro.AutoSize = true;
            this.lblGestPro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestPro.Location = new System.Drawing.Point(185, 136);
            this.lblGestPro.Name = "lblGestPro";
            this.lblGestPro.Size = new System.Drawing.Size(289, 75);
            this.lblGestPro.TabIndex = 0;
            this.lblGestPro.Text = "GestPro";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.btnConsPostes);
            this.grpBox.Controls.Add(this.btnConsFour);
            this.grpBox.Controls.Add(this.btnConsFid);
            this.grpBox.Controls.Add(this.btnConsProd);
            this.grpBox.Controls.Add(this.btnConsCom);
            this.grpBox.Controls.Add(this.btnConsEmp);
            this.grpBox.Location = new System.Drawing.Point(12, 248);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(625, 283);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Gestion des éléments";
            // 
            // btnConsPostes
            // 
            this.btnConsPostes.Location = new System.Drawing.Point(448, 184);
            this.btnConsPostes.Name = "btnConsPostes";
            this.btnConsPostes.Size = new System.Drawing.Size(171, 52);
            this.btnConsPostes.TabIndex = 4;
            this.btnConsPostes.Text = "Consulter les postes";
            this.btnConsPostes.UseVisualStyleBackColor = true;
            this.btnConsPostes.Click += new System.EventHandler(this.btnConsPostes_Click);
            // 
            // btnConsFour
            // 
            this.btnConsFour.Location = new System.Drawing.Point(231, 184);
            this.btnConsFour.Name = "btnConsFour";
            this.btnConsFour.Size = new System.Drawing.Size(171, 52);
            this.btnConsFour.TabIndex = 3;
            this.btnConsFour.Text = "Consulter les fournisseurs";
            this.btnConsFour.UseVisualStyleBackColor = true;
            this.btnConsFour.Click += new System.EventHandler(this.btnConsFour_Click);
            // 
            // btnConsFid
            // 
            this.btnConsFid.Location = new System.Drawing.Point(6, 184);
            this.btnConsFid.Name = "btnConsFid";
            this.btnConsFid.Size = new System.Drawing.Size(171, 52);
            this.btnConsFid.TabIndex = 2;
            this.btnConsFid.Text = "Consulter les clients fidèles";
            this.btnConsFid.UseVisualStyleBackColor = true;
            this.btnConsFid.Click += new System.EventHandler(this.btnConsFid_Click);
            // 
            // btnConsProd
            // 
            this.btnConsProd.Location = new System.Drawing.Point(231, 39);
            this.btnConsProd.Name = "btnConsProd";
            this.btnConsProd.Size = new System.Drawing.Size(171, 52);
            this.btnConsProd.TabIndex = 1;
            this.btnConsProd.Text = "Consulter les produits";
            this.btnConsProd.UseVisualStyleBackColor = true;
            this.btnConsProd.Click += new System.EventHandler(this.btnConsProd_Click);
            // 
            // btnConsCom
            // 
            this.btnConsCom.Location = new System.Drawing.Point(448, 39);
            this.btnConsCom.Name = "btnConsCom";
            this.btnConsCom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsCom.Size = new System.Drawing.Size(171, 52);
            this.btnConsCom.TabIndex = 1;
            this.btnConsCom.Text = "Consulter les commandes";
            this.btnConsCom.UseVisualStyleBackColor = true;
            this.btnConsCom.Click += new System.EventHandler(this.btnConsCom_Click);
            // 
            // btnConsEmp
            // 
            this.btnConsEmp.Location = new System.Drawing.Point(6, 39);
            this.btnConsEmp.Name = "btnConsEmp";
            this.btnConsEmp.Size = new System.Drawing.Size(171, 52);
            this.btnConsEmp.TabIndex = 0;
            this.btnConsEmp.Text = "Consulter les employés";
            this.btnConsEmp.UseVisualStyleBackColor = true;
            this.btnConsEmp.Click += new System.EventHandler(this.btnConsEmp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 543);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.lblGestPro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GestPro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.grpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGestPro;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnConsPostes;
        private System.Windows.Forms.Button btnConsFour;
        private System.Windows.Forms.Button btnConsFid;
        private System.Windows.Forms.Button btnConsProd;
        private System.Windows.Forms.Button btnConsCom;
        private System.Windows.Forms.Button btnConsEmp;
    }
}

