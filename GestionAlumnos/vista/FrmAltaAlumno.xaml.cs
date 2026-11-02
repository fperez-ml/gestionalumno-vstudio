using GestionAlumnos.modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GestionAlumnos.vista
{
    /// <summary>
    /// Interaction logic for FrmAltaAlumno.xaml
    /// </summary>
    public partial class FrmAltaAlumno : Window
    {
        public Alumno alumno = null;
        public FrmAltaAlumno()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.txtCurso.Text = "";
            this.txtNombre.Text = "";
        }

        private void btnAltaAlumno_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(this.txtNombre.Text) || String.IsNullOrEmpty(this.txtCurso.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos");
                return;
            }
            
            alumno = new Alumno(this.txtNombre.Text, this.txtCurso.Text);
            this.DialogResult = true;
            Close();
        }

        private void btnAltaAlumnoCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            Close();
        }
    }
}
