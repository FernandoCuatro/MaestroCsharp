﻿namespace Ejercicio01Directorios
{
 partial class Buscador
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
   this.components = new System.ComponentModel.Container();
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
   this.label1 = new System.Windows.Forms.Label();
   this.txtRuta = new System.Windows.Forms.TextBox();
   this.btnBuscar = new System.Windows.Forms.Button();
   this.groupBox1 = new System.Windows.Forms.GroupBox();
   this.lbDatos = new System.Windows.Forms.ListBox();
   this.btnLimpiar = new System.Windows.Forms.Button();
   this.btnFiltrar = new System.Windows.Forms.Button();
   this.cboArchivos = new System.Windows.Forms.ComboBox();
   this.errorDatos = new System.Windows.Forms.ErrorProvider(this.components);
   this.groupBox1.SuspendLayout();
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).BeginInit();
   this.SuspendLayout();
   // 
   // label1
   // 
   this.label1.AutoSize = true;
   this.label1.Location = new System.Drawing.Point(12, 21);
   this.label1.Name = "label1";
   this.label1.Size = new System.Drawing.Size(87, 13);
   this.label1.TabIndex = 0;
   this.label1.Text = "Ruta especifica: ";
   // 
   // txtRuta
   // 
   this.txtRuta.Location = new System.Drawing.Point(105, 18);
   this.txtRuta.Name = "txtRuta";
   this.txtRuta.ReadOnly = true;
   this.txtRuta.Size = new System.Drawing.Size(353, 20);
   this.txtRuta.TabIndex = 1;
   // 
   // btnBuscar
   // 
   this.btnBuscar.Location = new System.Drawing.Point(479, 16);
   this.btnBuscar.Name = "btnBuscar";
   this.btnBuscar.Size = new System.Drawing.Size(75, 23);
   this.btnBuscar.TabIndex = 2;
   this.btnBuscar.Text = "...";
   this.btnBuscar.UseVisualStyleBackColor = true;
   this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
   // 
   // groupBox1
   // 
   this.groupBox1.Controls.Add(this.lbDatos);
   this.groupBox1.Controls.Add(this.btnLimpiar);
   this.groupBox1.Controls.Add(this.btnFiltrar);
   this.groupBox1.Controls.Add(this.cboArchivos);
   this.groupBox1.Location = new System.Drawing.Point(15, 72);
   this.groupBox1.Name = "groupBox1";
   this.groupBox1.Size = new System.Drawing.Size(539, 306);
   this.groupBox1.TabIndex = 3;
   this.groupBox1.TabStop = false;
   this.groupBox1.Text = "Busquedas de archivos";
   // 
   // lbDatos
   // 
   this.lbDatos.FormattingEnabled = true;
   this.lbDatos.Location = new System.Drawing.Point(90, 102);
   this.lbDatos.Name = "lbDatos";
   this.lbDatos.Size = new System.Drawing.Size(353, 186);
   this.lbDatos.TabIndex = 3;
   this.lbDatos.DoubleClick += new System.EventHandler(this.mostrarArchivos);
   // 
   // btnLimpiar
   // 
   this.btnLimpiar.Location = new System.Drawing.Point(266, 46);
   this.btnLimpiar.Name = "btnLimpiar";
   this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
   this.btnLimpiar.TabIndex = 2;
   this.btnLimpiar.Text = "Limpiar";
   this.btnLimpiar.UseVisualStyleBackColor = true;
   this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
   // 
   // btnFiltrar
   // 
   this.btnFiltrar.Location = new System.Drawing.Point(172, 46);
   this.btnFiltrar.Name = "btnFiltrar";
   this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
   this.btnFiltrar.TabIndex = 1;
   this.btnFiltrar.Text = "Filtrar";
   this.btnFiltrar.UseVisualStyleBackColor = true;
   this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
   // 
   // cboArchivos
   // 
   this.cboArchivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
   this.cboArchivos.FormattingEnabled = true;
   this.cboArchivos.Location = new System.Drawing.Point(90, 19);
   this.cboArchivos.Name = "cboArchivos";
   this.cboArchivos.Size = new System.Drawing.Size(353, 21);
   this.cboArchivos.TabIndex = 0;
   // 
   // errorDatos
   // 
   this.errorDatos.ContainerControl = this;
   // 
   // Buscador
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.AutoSize = true;
   this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
   this.BackColor = System.Drawing.Color.Gainsboro;
   this.ClientSize = new System.Drawing.Size(573, 404);
   this.Controls.Add(this.groupBox1);
   this.Controls.Add(this.btnBuscar);
   this.Controls.Add(this.txtRuta);
   this.Controls.Add(this.label1);
   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
   this.MaximizeBox = false;
   this.Name = "Buscador";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
   this.Text = "Buscador de archivos";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.groupBox1.ResumeLayout(false);
   ((System.ComponentModel.ISupportInitialize)(this.errorDatos)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();

  }

  #endregion

  private System.Windows.Forms.Label label1;
  private System.Windows.Forms.TextBox txtRuta;
  private System.Windows.Forms.Button btnBuscar;
  private System.Windows.Forms.GroupBox groupBox1;
  private System.Windows.Forms.ListBox lbDatos;
  private System.Windows.Forms.Button btnLimpiar;
  private System.Windows.Forms.Button btnFiltrar;
  private System.Windows.Forms.ComboBox cboArchivos;
  private System.Windows.Forms.ErrorProvider errorDatos;
 }
}

