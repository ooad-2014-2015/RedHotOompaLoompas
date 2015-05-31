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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Printing;


namespace PrintTest4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //kreiranje dokumenta
        //ovaj doc bi trebalo prilagoditi nasim potrebama
        private FlowDocument CreateFlowDocument()
        {
            // Kreiranje FlowDocument
            FlowDocument doc = new FlowDocument();

            // Kreiranje Section
            Section sec = new Section();

            // Kreiranje paragrafa, tj. naseg teksta
            Paragraph p1 = new Paragraph();

            // Dodavanje osobina, isto prema nasim potrebama
            Bold bld = new Bold();
            bld.Inlines.Add(new Run("Ovo je tekst gdje treba nesto ispisati"));
            Italic italicBld = new Italic();
            italicBld.Inlines.Add(bld);
            Underline underlineItalicBld = new Underline();
            underlineItalicBld.Inlines.Add(italicBld);

            // Dodavanje osobina za paragraf
            p1.Inlines.Add(underlineItalicBld);

            // Dodavanje paragrafa u sekciju
            sec.Blocks.Add(p1);

            // Dodavanje sekcijeu FlowDocument
            doc.Blocks.Add(sec);

            return doc;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kreiranje PrintDialog
                PrintDialog printDlg = new PrintDialog();
                printDlg.PageRangeSelection = PageRangeSelection.AllPages;
                printDlg.UserPageRangeEnabled = true;
                var doPrint = printDlg.ShowDialog();
                if (doPrint != true)
                {
                    MessageBox.Show("nesto ne valja.");
                    return;
                }

                // Kreiranje FlowDocument pomocu metode CreateFlowDocument()
                FlowDocument doc = CreateFlowDocument();
                doc.Name = "FlowDoc";

                // Kreiranje IDocumentPaginatorSource
                IDocumentPaginatorSource idpSource = doc;

                // Slanje dokumenta printeru
                printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");
            }
            catch
            {
                MessageBox.Show("belaj");
            }
        }
    }
}
