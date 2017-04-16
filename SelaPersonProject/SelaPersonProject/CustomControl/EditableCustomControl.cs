using System.Windows;
using System.Windows.Controls;

namespace SelaPersonProject.CustomControl
{
    public class EditableCustomControl : Control
    {
        static EditableCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EditableCustomControl),
                new FrameworkPropertyMetadata(typeof(EditableCustomControl)));
        }

        #region TextBox

        public static readonly DependencyProperty TextDataProperty = DependencyProperty.Register(
            "TextData", typeof(string), typeof(EditableCustomControl), new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, TextPropertyChangedCallback));

        private static void TextPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var editableCustomControl = d as EditableCustomControl;

            if (e.OldValue != e.NewValue)
                editableCustomControl?.SetValue(TextDataProperty, e.NewValue);
        }

        public string TextData
        {
            get { return (string)GetValue(TextDataProperty); }
            set { SetValue(TextDataProperty, value); }
        }

        #endregion

        #region IsChecked

        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register(
            "IsChecked", typeof(bool), typeof(EditableCustomControl), new PropertyMetadata(default(bool), PropertyChangedCallback));

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        private static void PropertyChangedCallback(DependencyObject dependencyObject,
         DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var control = (EditableCustomControl)dependencyObject;
            control.IsChecked = (bool)dependencyPropertyChangedEventArgs.NewValue;
        }

        #endregion
    }
}
