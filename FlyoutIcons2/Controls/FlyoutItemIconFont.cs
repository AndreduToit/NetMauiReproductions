namespace MauiAppShell.Controls
{
    //see:https://stackoverflow.com/questions/65400688/xamarin-forms-how-can-i-change-the-flyoutitem-icons-color-when-it-is-selected
    //see:https://docs.microsoft.com/en-us/answers/questions/260997/how-do-i-change-the-color-of-an-icon-in-a-flyoutit.html
    public class FlyoutItemIconFont : FlyoutItem
    {
        public static readonly BindableProperty IconGlyphProperty = BindableProperty.Create(nameof(IconGlyphProperty), typeof(string), typeof(FlyoutItemIconFont), string.Empty);
        public string IconGlyph
        {
            get { return (string)GetValue(IconGlyphProperty); }
            set
            {
                //Sets the following: this.IconGlyph = value;
                SetValue(IconGlyphProperty, value);
            }
        }
    }
}
