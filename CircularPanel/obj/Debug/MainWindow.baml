   M S B A M L   `   `   `  ����H  DCircularPanel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CircularPanelCircularPanel  5   	       CircularPanel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5circluarPanelclr-namespace:CircularPanel     5   	   -   5          �Name$  myWindow��5   	    � Title$ 
MainWindow��5   	   $	��530��6   $	��700��6)    � 	Resources 5         buttonStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6$   .�5	      ��  � ��$ Center=�64   6E   �� 5
       � ��$
 4, 2q�6(   67   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $	��44* �6   6+   �� 5      $��3* �6   6*    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� -   5         ��Name$ AngleSlider��5      	 � Minimum$	 0Q�6&   
 � Maximum$	
 360Q�62   $��2��6@   $��0��6T   6c   #  CircularPanel.MyCircularPanel  5   
   -   5          Name$ myCircularPanel��5   I   $��2��6(   $��1��6<   $	��Top=�6b      Angle 5   (   ��  �� ElementName$ AngleSlider�� �� Path$ Value�.+�5      �� -   5        
���  ��$��25��5   #   $��50��6.   6X   �� 5      -   5        
����  �$��75��5   $   $��50��6/   6Y   �� 5      -   5        
��� ���$��50��5   &   $��25��61   6[   �� 5      -   5        
��� � �$��50��5   %   $��75��60   6Z   5      �� 5   
   -   5         ��Name$ addRectangleButton��5   6   #��[  6   $��0��6R   $��2��6b   $��Add Rectangle��6o   6�   �� 5    
   -	   5        $ removeRectangleButton��5    6   #��[  6   $��1��6U   $��2��6e   $��Remove Rectangle��6r   6�   5!      5"      