﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuestroPrimerFormulario
{
 public partial class frmCapturarDatosDateTimePicker : Form
 {
  public frmCapturarDatosDateTimePicker()
  {
   InitializeComponent();
  }

  private void btnMostrar_Click(object sender, EventArgs e)
  {
   DateTime Fecha = dtpFecha.Value;
   lblRespuesta.Text = "La fecha es: " + Fecha;
  }
 }
}
