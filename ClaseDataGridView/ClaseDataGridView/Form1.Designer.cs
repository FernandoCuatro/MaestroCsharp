﻿namespace ClaseDataGridView
{
 partial class Form1
 {
  /// <summary>
  /// Variable del diseñador necesaria.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Limpiar los recursos que se estén usando.
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
  /// el contenido de este método con el editor de código.
  /// </summary>
  private void InitializeComponent()
  {
   this.dgvPersona = new System.Windows.Forms.DataGridView();
   this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
   this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
   ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
   this.SuspendLayout();
   // 
   // dgvPersona
   // 
   this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.edad});
   this.dgvPersona.Location = new System.Drawing.Point(12, 34);
   this.dgvPersona.Name = "dgvPersona";
   this.dgvPersona.Size = new System.Drawing.Size(333, 150);
   this.dgvPersona.TabIndex = 0;
   // 
   // Nombre
   // 
   this.Nombre.HeaderText = "Nombre";
   this.Nombre.Name = "Nombre";
   // 
   // Apellido
   // 
   this.Apellido.HeaderText = "Apellido";
   this.Apellido.Name = "Apellido";
   // 
   // edad
   // 
   this.edad.HeaderText = "edad";
   this.edad.Name = "edad";
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(357, 261);
   this.Controls.Add(this.dgvPersona);
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.DataGridView dgvPersona;
  private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
  private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
  private System.Windows.Forms.DataGridViewTextBoxColumn edad;
 }
}

