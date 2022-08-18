using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiApp1
{
    public class ViewModelMainPage : ObservableObject
    {
        int count = 0;
        string counterBtnText = "Click me";

        ModelCollectionViewItem? selectedItem;
    
        public ObservableCollection<ModelCollectionViewItem> PageItems { get; set; }
   
        public string ButtonText
        {
            get => counterBtnText;
            set => SetProperty(ref counterBtnText, value);
        }
        public ModelCollectionViewItem? SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
                if (selectedItem != null)
                {
                    foreach (var item in PageItems) 
                    {
                        item.BackgroudColor = Colors.Transparent;
                    }
                    selectedItem.BackgroudColor = Colors.Green;
                }
            }
        }


        public Command CounterClick { get; }
        public ViewModelMainPage()
        {
            CounterClick = new Command(OnCounterClicked);
            PageItems = new ObservableCollection<ModelCollectionViewItem>();
            var action = new Action<int>(SelectedItemClicked);
            PageItems.Add(new ModelCollectionViewItem(1, "Column0_1", "More Text Column0_1", action));
            PageItems.Add(new ModelCollectionViewItem(2, "Column0_2", "More Text Column0_2", action));
            PageItems.Add(new ModelCollectionViewItem(3, "Column0_3", "More Text Column0_3", action));
            PageItems.Add(new ModelCollectionViewItem(4, "Column0_4", "More Text Column0_4", action));
            PageItems.Add(new ModelCollectionViewItem(5, "Column0_5", "More Text Column0_5", action));
        }
        private void OnCounterClicked(object? sender)
        {
            count++;

            if (count == 1)
                ButtonText = $"Clicked {count} time";
            else
                ButtonText = $"Clicked {count} times";
        }
        private void SelectedItemClicked(int id)
        {
            SelectedItem = PageItems.Where(a => a.Id == id).FirstOrDefault();
        }

    }
}
