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

namespace Radio_button
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

                if ((bool)addition.IsChecked)
                {

                    addValues();

                }

            }

            catch (Exception caught)
            {

                expression.Text = "";

                result.Text = caught.Message;

            }
        }
        private void addValues()
        {

            int lhs = int.Parse(lhsOperand.Text);

            int rhs = int.Parse(rhsOperand.Text);

            int outcome = 0;

            // TODO: cộng lhs và rhs, lưu trong outcome

            outcome = lhs + rhs;

            expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;

            result.Text = outcome.ToString();

        }
    }
}
