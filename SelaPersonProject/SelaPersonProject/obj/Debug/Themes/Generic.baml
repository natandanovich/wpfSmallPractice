   M S B A M L   `   `   `  ����L  HSelaPersonProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SelaPersonProject.ConvertorsSelaPersonProject.Convertors  5      Q-clr-namespace:SelaPersonProject.CustomControlSelaPersonProject.CustomControl  5      g cExpression.Samples.Interactivity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=c7dd7e4745814058}Xclr-namespace:Expression.Samples.Interactivity;assembly=Expression.Samples.Interactivity Expression.Samples.Interactivity 5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e359    3SelaPersonProject.Convertors.InvertBooleanConvertor   InvertBooleanConvertor;   5SelaPersonProject.CustomControl.EditableCustomControl  �� 
TargetType �� Property �� Value �� 
TargetType �� Orientation ��Name �� 
IsReadOnly �� ElementName �� 	Converter	 �� Path
 �� Mode �� RelativeSource �� Padding ��Name �� Triggers P� Property P� Value �� 
TargetName d�Name � ToolTip.  (System.Windows.Interactivity.Interaction   Triggers/  )System.Windows.Interactivity.EventTrigger   	EventName3  -System.Windows.Interactivity.EventTriggerBase   
SourceName.  (System.Windows.Interactivity.TriggerBase   Actions2  ,Expression.Samples.Interactivity.SetProperty   PropertyName   Value8  2System.Windows.Interactivity.TargetedTriggerAction   
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      9
converters*clr-namespace:SelaPersonProject.Convertors  5      ?customControl-clr-namespace:SelaPersonProject.CustomControl  5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      _siXclr-namespace:Expression.Samples.Interactivity;assembly=Expression.Samples.Interactivity  5      %H	  &	        '       7      5	      6(   �� 5      "   6   .�5   
   ��  � �� 5      �� 5      "  6"   .R�5      �� #��z��5      #��z��5      #��z��5      ._�5      � .+�5      �� $��	10,0,10,0q�6)   $ 
Horizontal=�6<   .+�5   "   �� $ PART_textbox��5   %   $��20��5   %   $��80��5   %    5   %   �� $ PART_toggle��8   $	 	IsChecked�$
 TwoWay=���5   %   �� *
TextData+$
 TwoWay=� �� *TemplatedParent+.��6}   ��5   &   �� 5   *   "  ��60   .�5   .   ��  �@J�SnapsToDevicePixels . 6T   �� 5   .    �@�OverridesDefaultStyle . 6V   �� 5   .    �@�FocusVisualStyle 6Q   Z� �� 5    .    �@J�	AllowDrop . 6J   �� 5!   .    � �� 5"   2   �� 5#   6   " ��6F   .R�5$   :   �� $��Border��5%   =   $ 0q�5&   =   ���#FFFFFF���#888888$��1q�5)   =   ._�5*   >   �� $ PART_ContentHost��6K   $��0q�6e   5+   ;    5,   :   P� 5-   >    � {� .  . �5.   B   �� $ Border��6I    � �� �#EEEEEE6s   �� 5/   B   $ Border��6I    � �� �#EEEEEE6t   �� 50   B    � �� �#8888886_   51   ?   P� 52   >    �@J�	IsFocused . . �53   B   �� $ Border��6I    � ��
 � � �6t   �� 54   B   $ Border��6I    � ��$ 2q�6x   55   ?   P� 57   >    �@��
IsReadOnly . . �58   B   �� $ Border��6I    � ��
 �����6t   �� 59   B   $ Border��6I    � ��$ 2q�6x   5:   ?   5<   7   5>   /   5?   +   .��5A   5   5C   #   d� 5D   "   $ PART_toggle��5E   %   $��25��5F   %   $��20��5G   %   $
��Edit��5H   %   $
 Edit��5I   %    5J   &     5K   *   $ 	LostFocus��69   $ PART_textbox��6O   . 5L   .     $ 	IsEnabled��6=   $
 True��6V     5M   .   $ 
IsReadOnly��5N   1   $ PART_textbox��5O   1   $
 True��5P   1   5Q   +     5R   *   $ PreviewLostKeyboardFocus��69   $ PART_textbox��6^   . 5S   .     $ 	IsEnabled��6=   $
 True��6V     5T   .   $ 
IsReadOnly��5U   1   $ PART_textbox��5V   1   $
 True��5W   1   5X   +     5Y   *   $ Click��69   . 5Z   .     $ 	IsEnabled��6=   $ False��6V     5[   .   $ 
IsReadOnly��5\   1   $ PART_textbox��5]   1   $ False��5^   1   5_   +   5a   #   5b      5c      5d      5e      5g      5h      5i      