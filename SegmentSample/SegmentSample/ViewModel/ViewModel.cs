using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace SegmentSample
{
  public class ViewModel 
    {
        public Command SelectionChangedCommand
        {
            get;
            set;
        }
        public ViewModel()
        {
            SelectionChangedCommand = new Command<Syncfusion.XForms.Buttons.SelectionChangedEventArgs>(SelectionChanged);
            ItemCollection = new ObservableCollection<SfSegmentItem>
                    {
                        new SfSegmentItem() {  Text = "Once"},
                        new SfSegmentItem() {  Text = "Daily"},
                        new SfSegmentItem() {  Text = "Weekly"},
                        new SfSegmentItem() {  Text = "Monthly"},
                        new SfSegmentItem() {  Text = "Yearly"},
                    };
        }

        private void SelectionChanged(Syncfusion.XForms.Buttons.SelectionChangedEventArgs obj)
        {
            Application.Current.MainPage.DisplayAlert("Notification", "The Selected Index: " + obj.Index, "Ok");
        }

        private ObservableCollection<SfSegmentItem> itemCollection = new ObservableCollection<SfSegmentItem>();
      
        public ObservableCollection<SfSegmentItem> ItemCollection
        {
            get { return itemCollection; }
            set { itemCollection = value; }
        }
    }
}