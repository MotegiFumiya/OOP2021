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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        private Random random = new Random();
        private int answerNum;
        private const int Rows = 5;
        private const int Columns = 5;

        private SolidColorBrush selectedButtonColor = new SolidColorBrush(Colors.Yellow);
        private SolidColorBrush hitButtonColor = new SolidColorBrush(Colors.Red);
        //private object MainForm;

        public MainWindow() {
            InitializeComponent();
        }

        private void MainDisp_Loaded(object sender,RoutedEventArgs e) {
            List<Button> buttons = new List<Button>();
            
            answerNum = random.Next(Rows * Columns) + 1;


            for(int i=0;i<Rows;i++) {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i=0;i<Columns;i++) {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            
            //ボタン
            for(int i = 0; i < Rows; i++) {
                for(int j = 0; j < Columns; j++) {
                    var bt = new Button();
                    bt.Width = MainForm.Width / Columns;
                    bt.Height = MainForm.Height/ Rows;
                    bt.Content = (i + 1) + i * Rows;
                    bt.FontSize = 20;
                    bt.Click += Bt_Click;
                    Grid.SetRow(bt, i);
                    Grid.SetColumn(bt,j);
                    //grid.Children.Add(bt);
                    buttons.Add(bt);
                }
            }
            buttons.ForEach(bt => grid.Children.Add(bt));

        }

        private void Bt_Click(object sender,RoutedEventArgs e) {
            Button selectedButton = (Button)sender;
            int num =(int)selectedButton.Content;
        }

    }
}