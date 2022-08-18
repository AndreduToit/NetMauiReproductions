
using System.Diagnostics;

namespace MauiApp1
{
    public class ModelCollectionViewItem : ObservableObject
    {
        #region fields

        private int id = 0;
        private string column0 = string.Empty;
        private string column1 = string.Empty;
        private Color backgroundcolor = Colors.Transparent;

        #endregion
        public Command DataTemplateSelectionClick { get; }
        public Command DataTemplateSelectionDoubleClick { get; }

        public ModelCollectionViewItem(int id, string column0, string column1, Action<int> action)
        {
            DataTemplateSelectionClick = new Command(OnDataTemplateSelectionClicked);
            DataTemplateSelectionDoubleClick = new Command(OnDataTemplateSelectionDoubleClicked);
            Id = id;
            Column0 = column0;
            Column1 = column1;
            ClickAction = action;
        }

        #region properties

        private Action<int> ClickAction { get; set; }
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
   
        public string Column0
        {
            get => column0;
            set => SetProperty(ref column0, value);
        }

        public string Column1
        {
            get => column1;
            set => SetProperty(ref column1, value);
        }

        public Color BackgroudColor
        {
            get => backgroundcolor;
            set => SetProperty(ref backgroundcolor, value);
        }

        #endregion
        private void OnDataTemplateSelectionClicked(object? sender)
        {
            ClickAction(Id);
        }
        private void OnDataTemplateSelectionDoubleClicked(object? sender)
        {
            BackgroudColor = Colors.Red;
        }


    }
}
