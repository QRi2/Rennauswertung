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
    /// Hier werden alle Daten rund um das Rennen gesammelt. 
    /// (Anzahl Runden, Anzahl Lines sowie Vernstaltungsort) 
    /// </summary>
    public partial class Eckdaten : Window
    {
        private string ort = "";
        private int linesAnzahl = 0;
        private int rundenAnzahl = 0;

        public Eckdaten()
        {
            InitializeComponent();
        }

        private void BtnAbbrechen_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!this.ort.Equals(String.Empty))
            {               
                    if (this.rundenAnzahl > 0)
                    {
                        if (this.linesAnzahl > 0)
                        {
                        new Tabelle(linesAnzahl, rundenAnzahl, ort, DateTime.Now.ToString("dd.MM.yyyy")).Show();
                        this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bitte geben Sie eine Zahl größer 0 ein!");
                            TbxLinesanzahl.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bitte geben Sie eine Rundenanzahl größer 0 ein!");
                        TbxRundenanzahl.Focus();
                    }                
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort an.");
                TbxOrt.Focus();
            }
        }

        private void TbxOrt_LostFocus(object sender, RoutedEventArgs e)
        {
            this.ort = TbxOrt.Text;
        }       

        private void TbxLinesanzahl_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.linesAnzahl = konvertiereTextfeldZuAttribut(TbxLinesanzahl);

        }

        private void TbxRundenanzahl_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.rundenAnzahl = konvertiereTextfeldZuAttribut(TbxRundenanzahl);

        }
       
        private int konvertiereTextfeldZuAttribut(TextBox textBox)
        {
            if (!textBox.Text.Equals(String.Empty))
            {
                try
                {
                    return Convert.ToInt32(textBox.Text);
                }
                catch
                {
                    MessageBox.Show("Bitte geben Sie eine valide Zahl ein");
                }
            }
            return 0;
        }
    }
}
