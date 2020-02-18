using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Rennauswertung
{
    /// <summary>
    /// Interaktionslogik für Tabelle.xaml
    /// </summary>
    public partial class Tabelle : Window
    {
        private int anzahlLines;
        private int anzahlRunden;

        public Tabelle(int anzahlLines, int anzahlRunden, string ort, string datum)
        {
            this.anzahlLines = anzahlLines;
            this.anzahlRunden = anzahlRunden;
            this.Title = "Rennauswertung " + ort + " " + datum;
            InitializeComponent();
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExport_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLinehinzufuegen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
