   M S B A M L   `   `   `  ���� H  DCircularPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CircularPanelCircularPanel      CircularPanel.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5circluarPanelclr-namespace:CircularPanel     -     �Name$  myWindow�� � Title$ 
MainWindow��$	��530��$	��700�� � 	Resources    buttonStyle �� 
TargetType �� Property �� Value��%I   &	        �� " ��.���  � ��$ Center=���  � ��$
 4, 2q�.���  � RowDefinitions �� $��2* ��� $	��44* ��� $��3* � � ColumnDefinitions �� $��* ��� $��* �.+��� -    ��Name$ AngleSlider��	 � Minimum$	 0Q�
 � Maximum$	
 360Q�$��2��$��0��#  CircularPanel.MyCircularPanel  -     Name$ myCircularPanel��$��2��$��1��$	��Top=�   Angle ��  �� ElementName$ AngleSlider�� �� Path$ Value�.+��� 
���  ��$��25��$��50���� 
����  �$��75��$��50���� 
��� ���$��50��$��25���� 
��� � �$��50��$��75���� -    ��Name$ addRectangleButton��#��[  $��0��$��2��$��Add Rectangle���� -   $ removeRectangleButton��#��[  $��1��$��2��$��Remove Rectangle��