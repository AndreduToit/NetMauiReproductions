using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1
{
    public interface IObservableObject
    {
        bool SetProperty<T>(ref T backingStore, T value, string propertyName, Action onChanged);

        void OnPropertyChanged(string propertyName);

    }

    public class ObservableObject : INotifyPropertyChanged, IObservableObject
    {


        public bool SetProperty<T>(ref T backingStore, T value,
                                        [CallerMemberName] string propertyName = "",
                                        Action? onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var tChanged = PropertyChanged;
            if (tChanged == null)
                return;

            tChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}