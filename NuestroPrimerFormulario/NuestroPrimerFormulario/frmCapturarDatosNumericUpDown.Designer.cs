﻿namespace NuestroPrimerFormulario
{
 partial class frmCapturarDatosNumericUpDown
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
   this.label1 = new System.Windows.Forms.Label();
   this.txtValor = new System.Windows.Forms.NumericUpDown();
   this.lblRespuesta = new System.Windows.Forms.Label();
   this.btnMostrar = new System.Windows.Forms.Button();
   this.btnLimpiar = new System.Windows.Forms.Button();
   ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(36, 33);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(95, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Inserte un numero:";
   // 
   // txtValor
   // 
   this.txtValor.Location = new System.Drawing.Point(138, 25);
   this.txtValor.Name = "txtValor";
   this.txtValor.Size = new System.Drawing.Size(120, 20);
   this.txtValor.TabIndex = 1;
   // 
   // lblRespuesta
   // 
   this.lblRespuesta.AutoSize = true;
   this.lblRespuesta.Location = new System.Drawing.Point(39, 119);
   this.lblRespuesta.Name = "lblRespuesta";
   this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
   this.lblRespuesta.TabIndex = 2;
   // 
   // btnMostrar
   // 
   this.btnMostrar.Location = new System.Drawing.Point(39, 76);
   this.btnMostrar.Name = "btnMostrar";
   this.btnMostrar.Size = new System.Drawing.Size(75, 23);
   this.btnMostrar.TabIndex = 3;
   this.btnMostrar.Text = "Mostrar";
   this.btnMostrar.UseVisualStyleBackColor = true;
   this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(183, 76);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 3;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // frmCapturarDatosNumericUpDown
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.btnLimpiar);
   this.Controls.Add(this.btnMostrar);
   this.Controls.Add(this.lblRespuesta);
   this.Controls.Add(this.txtValor);
   this.Controls.Add(this.label1);
   this.Name = "frmCapturarDatosNumericUpDown";
   this.Text = "frmCapturarDatosNumericUpDown";
   ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.NumericUpDown txtValor;
  private System.Windows.Forms.Label lblRespuesta;
  private System.Windows.Forms.Button btnMostrar;
  private System.Windows.Forms.Button btnLimpiar;
 }
}