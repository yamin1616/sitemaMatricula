﻿namespace frmSitemaMat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmabrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmabrir
            // 
            this.frmabrir.Location = new System.Drawing.Point(534, 30);
            this.frmabrir.Name = "frmabrir";
            this.frmabrir.Size = new System.Drawing.Size(75, 23);
            this.frmabrir.TabIndex = 0;
            this.frmabrir.Text = "Abrir";
            this.frmabrir.UseVisualStyleBackColor = true;
            this.frmabrir.Click += new System.EventHandler(this.frmabrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 285);
            this.Controls.Add(this.frmabrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frmabrir;
    }
}

