using GestionAlumnos.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for FormPrincipal.xaml
    /// </summary>
    public partial class FormPrincipal : Window
    {
        private readonly ObservableCollection<Alumno> alumnos = new();

        public FormPrincipal()
        {
            InitializeComponent();
            dgAlumnos.ItemsSource = alumnos;
        }
        
        private void FormularioPrincipal_Loaded(object sender, RoutedEventArgs e)
        {
            this.dgAlumnos.Columns.Add(new DataGridTextColumn() { Header = "Nombre", Binding = new Binding("Nombre") });
            this.dgAlumnos.Columns.Add(new DataGridTextColumn() { Header = "Curso", Binding = new Binding("Curso") });
        }
        
        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        private void menuItemSalir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void menuItemAlta_Click(object sender, RoutedEventArgs e)
        {
            FrmAltaAlumno frm = new FrmAltaAlumno();
            if (frm.ShowDialog() == true && frm.alumno != null)
            {
                alumnos.Add(frm.alumno);
            }
        }
    }
}
