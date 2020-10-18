using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }

        static FrameworkPropertyMetadata labelMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl));
        
        static FrameworkPropertyMetadata customerMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);

        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), customerMetadata);

        static FrameworkPropertyMetadata changeMetadata = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);

        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), changeMetadata);

        /// <summary>
        /// Represents the value held in currency control's label
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Represents the quantity of currency of a certain type the customer pays with
        /// </summary>
        public int CustomerQuantity
        {
            get { return (int)GetValue(CustomerQuantityProperty); }
            set { SetValue(CustomerQuantityProperty, value); }
        }

        /// <summary>
        /// Represents the quantity of currency of a certain type that the customer is owed in change
        /// </summary>
        public int ChangeQuantity
        {
            get { return (int)GetValue(ChangeQuantityProperty); }
            set { SetValue(ChangeQuantityProperty, value); }
        }

        /// <summary>
        /// Event handler for if the increment button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
            e.Handled = true;
        }

        /// <summary>
        /// Event handler for if the decrement button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            if (CustomerQuantity > 0)
            {
                CustomerQuantity--;
            }
            
            e.Handled = true;
        }

        public void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is CurrencyControl cc)
            {
                if (e.PropertyName == "CustomerQuantity")
                {

                }
                else if (e.PropertyName == "ChangeQuantity")
                {

                }
            }
        }
    }
}
