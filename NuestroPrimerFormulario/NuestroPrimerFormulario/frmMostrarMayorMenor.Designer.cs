﻿namespace NuestroPrimerFormulario
{
 partial class frmMostrarMayorMenor
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
   this.components = new System.ComponentModel.Container();
   this.label1 = new System.Windows.Forms.Label();
   this.txtEdad = new System.Windows.Forms.NumericUpDown();
   this.btnCalcular = new System.Windows.Forms.Button();
   this.lblMensaje = new System.Windows.Forms.Label();
   this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
   ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 26);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(75, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ingrese edad: ";
   // 
   // txtEdad
   // 
   this.txtEdad.Location = new System.Drawing.Point(93, 24);
   this.txtEdad.Name = "txtEdad";
   this.txtEdad.Size = new System.Drawing.Size(120, 20);
   this.txtEdad.TabIndex = 1;
   // 
   // btnCalcular
   // 
   this.btnCalcular.Location = new System.Drawing.Point(104, 63);
   this.btnCalcular.Name = "btnCalcular";
   this.btnCalcular.Size = new System.Drawing.Size(75, 23);
   this.btnCalcular.TabIndex = 2;
   this.btnCalcular.Text = "Calcular";
   this.btnCalcular.UseVisualStyleBackColor = true;
   this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
   // 
   // lblMensaje
   // 
   this.lblMensaje.AutoSize = true;
   this.lblMensaje.Location = new System.Drawing.Point(15, 112);
   this.lblMensaje.Name = "lblMensaje";
   this.lblMensaje.Size = new System.Drawing.Size(0, 13);
   this.lblMensaje.TabIndex = 3;
   // 
   // errorDatos
   // 
   this.errorDatos.ContainerControl = this;
   // 
   // frmMostrarMayorMenor
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(284, 261);
   this.Controls.Add(this.lblMensaje);
   this.Controls.Add(this.btnCalcular);
   this.Controls.Add(this.txtEdad);
   this.Controls.Add(this.label1);
   this.Name = "frmMostrarMayorMenor";
   this.Text = "frmMostrarMayorMenor";
   ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.NumericUpDown txtEdad;
  private System.Windows.Forms.Button btnCalcular;
  private System.Windows.Forms.Label lblMensaje;
  private System.Windows.Forms.ErrorProvider errorDatos;
 }
}